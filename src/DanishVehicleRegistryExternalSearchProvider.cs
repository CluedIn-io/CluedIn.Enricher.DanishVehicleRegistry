// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DanishVehicleRegistryExternalSearchProvider.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the danish vehicle registry external search provider class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;
using CluedIn.Crawling.Helpers;
using CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models;
using CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Vocabularies;

using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;

using RestSharp.Deserializers;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry
{
    /// <summary>The danishvehicleregistry graph external search provider.</summary>
    /// <seealso cref="CluedIn.ExternalSearch.ExternalSearchProviderBase" />
    public class DanishVehicleRegistryExternalSearchProvider : ExternalSearchProviderBase
    {
        public static readonly Guid ProviderId = Guid.Parse("469741ca-2fdf-4c8d-98ce-486ad2fface8");   // TODO: Replace value

        private string motorRegisterApiKey = "427B1C96-CDE9-48EA-894E-0AFA5FC0470C";

        /**********************************************************************************************************
         * CONSTRUCTORS
         **********************************************************************************************************/

        public DanishVehicleRegistryExternalSearchProvider()
            : base(ProviderId, EntityType.Infrastructure.User, EntityType.Infrastructure.Contact)
        {
#if (DEBUG)
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
#endif
        }

        /**********************************************************************************************************
         * METHODS
         **********************************************************************************************************/

        /// <summary>Builds the queries.</summary>
        /// <param name="context">The context.</param>
        /// <param name="request">The request.</param>
        /// <returns>The search queries.</returns>
        public override IEnumerable<IExternalSearchQuery> BuildQueries(ExecutionContext context, IExternalSearchRequest request)
        {
            if (!this.Accepts(request.EntityMetaData.EntityType))
                yield break;

            Func<string, bool> nameFilter = value => string.IsNullOrEmpty(value) || !value.Contains(" ");

            var homeAddressCountryCode  = request.QueryParameters.GetValue(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode, new HashSet<string>());
            var email                   = request.QueryParameters.GetValue(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email, new HashSet<string>());
            var emailAddresses          = request.QueryParameters.GetValue(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.EmailAddresses, new HashSet<string>());

            if (email != null)
                emailAddresses.AddRange(email);

            bool isEmailDanish = false;
            if (emailAddresses != null && emailAddresses.Any())
                isEmailDanish = emailAddresses.SelectMany(v => v.Split(new[] { ",", ";", "|" }, StringSplitOptions.RemoveEmptyEntries))
                                              .Any(x => x.EndsWith(".dk", StringComparison.OrdinalIgnoreCase));

            bool isFromDenmark = isEmailDanish
                              || homeAddressCountryCode.Any(c => c.Equals("dk", StringComparison.OrdinalIgnoreCase)
                                                              || c.Equals("denmark", StringComparison.OrdinalIgnoreCase)
                                                              || c.Equals("danmark", StringComparison.OrdinalIgnoreCase)
                                                           );

            if (!isFromDenmark)
                yield break;

            var entityType  = request.EntityMetaData.EntityType;
            var dateOfBirth = request.QueryParameters.GetValue(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday, new HashSet<string>());
            var fullName    = request.QueryParameters.GetValue(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName, new HashSet<string>());

            var names = new HashSet<string>();
            if (!string.IsNullOrEmpty(request.EntityMetaData.Name))
                names.Add(request.EntityMetaData.Name);
            if (!string.IsNullOrEmpty(request.EntityMetaData.DisplayName))
                names.Add(request.EntityMetaData.DisplayName);
            if (fullName != null)
                names.AddRange(fullName);

            if (names.Any() && dateOfBirth != null && dateOfBirth.Any())
            {
                foreach (var name in names.Where(v => !nameFilter(v)))
                {
                    var parsedDateOfBirth = DateTime.Parse(dateOfBirth.FirstOrDefault()).ToString("ddMMyy");

                    var person = new Dictionary<string, string>
                                     {
                                         { "name", name },
                                         { "dateOfBirth", parsedDateOfBirth }
                                     };

                    yield return new ExternalSearchQuery(this, entityType, person);
                }
            }
        }
 
        /// <summary>Executes the search.</summary>
        /// <param name="context">The context.</param>
        /// <param name="query">The query.</param>
        /// <returns>The results.</returns>
        public override IEnumerable<IExternalSearchQueryResult> ExecuteSearch(ExecutionContext context, IExternalSearchQuery query)
        {
            var name = query.QueryParameters["name"].FirstOrDefault();
            var dateOfBirth = query.QueryParameters["dateOfBirth"].FirstOrDefault();
           
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dateOfBirth))
                yield break;
 
            var tinglysningClient = new RestClient("https://www.tinglysning.dk/tinglysning/unsecrest/");
            var tinglysningSearchResponseData = JsonRequestWrapper<TinglysningSearchResponse>(tinglysningClient, String.Format("soegbil?fdato={0}&navn={1}", dateOfBirth, name), Method.GET);

            if (tinglysningSearchResponseData != null)
            {
                var combinedCarLookupCollection = new CombinedCarLookupCollection(name, dateOfBirth);

                var motorRegisterClient = new RestClient("https://motorregisterapi.com/api/vehicles/")
                {
                    Authenticator = new HttpBasicAuthenticator(motorRegisterApiKey, motorRegisterApiKey)
                };

                foreach (var car in tinglysningSearchResponseData.Items)
                {
                    var cl = new CombinedCarLookup();

                    var td = XmlRequestWrapper<BilSummariskHentResultat>(tinglysningClient, String.Format("bil/uuid/{0}", car.Id), Method.GET);
                    var md = JsonRequestWrapper<MotorRegistryResponse>(motorRegisterClient, String.Format("get/{0}", car.NumberPlate), Method.GET);

                    if (td != null && md != null)
                    {
                        cl.Brand = md.VehicleInfoBrandTypeName;
                        cl.Kind = md.VehicleKindName;
                        cl.KmPerLiter = md.VehicleMotorKmPerLiter;
                        cl.MaxSpeed = md.VehicleInfoMaximumSpeed;
                        cl.Model = md.VehicleInfoModelTypeName;
                        cl.ModelYear = md.VehicleInfoModelYear;
                        cl.NumberPlate = md.LicensePlateNumber;
                        cl.Power = md.VehicleMotorBiggestEffect;
                        cl.VehicleIdentificationNumber = md.VehicleIdentityNumber;

                        cl.DateOfDebt = td.BilSummarisk.HaeftelseSummariskSamling.HaeftelseSummarisk.TinglysningsDato;
                        cl.InitialDebt = td.BilSummarisk.HaeftelseSummariskSamling.HaeftelseSummarisk.HaeftelseBeloeb.BeloebValuta.BeloebVaerdi;
                        cl.Currency = td.BilSummarisk.HaeftelseSummariskSamling.HaeftelseSummarisk.HaeftelseBeloeb.BeloebValuta.ValutaKode;
                    }

                    combinedCarLookupCollection.Lookups.Add(cl);
                }

                yield return new ExternalSearchQueryResult<CombinedCarLookupCollection>(query, combinedCarLookupCollection);
            }
        }
 
        /// <summary>Builds the clues.</summary>
        /// <param name="context">The context.</param>
        /// <param name="query">The query.</param>
        /// <param name="result">The result.</param>
        /// <param name="request">The request.</param>
        /// <returns>The clues.</returns>
        public override IEnumerable<Clue> BuildClues(ExecutionContext context, IExternalSearchQuery query, IExternalSearchQueryResult result, IExternalSearchRequest request)
        {
            var resultItem = result.As<CombinedCarLookupCollection>();
 
            var code = this.GetOriginEntityCode(resultItem);
 
            var clue = new Clue(code, context.Organization);

            this.PopulateMetadata(clue.Data.EntityData, resultItem);

            var c = clue.Serialize();
 
            return new[] { clue };
        }
 
        /// <summary>Gets the primary entity metadata.</summary>
        /// <param name="context">The context.</param>
        /// <param name="result">The result.</param>
        /// <param name="request">The request.</param>
        /// <returns>The primary entity metadata.</returns>
        public override IEntityMetadata GetPrimaryEntityMetadata(ExecutionContext context, IExternalSearchQueryResult result, IExternalSearchRequest request)
        {
            var resultItem = result.As<CombinedCarLookupCollection>();
            return this.CreateMetadata(resultItem);
        }

        /// <summary>Gets the preview image.</summary>
        /// <param name="context">The context.</param>
        /// <param name="result">The result.</param>
        /// <param name="request">The request.</param>
        /// <returns>The preview image.</returns>
        public override IPreviewImage GetPrimaryEntityPreviewImage(ExecutionContext context, IExternalSearchQueryResult result, IExternalSearchRequest request)
        {
            return null;
        }
 
        /// <summary>Creates the metadata.</summary>
        /// <param name="resultItem">The result item.</param>
        /// <returns>The metadata.</returns>
        private IEntityMetadata CreateMetadata(IExternalSearchQueryResult<CombinedCarLookupCollection> resultItem)
        {
            var metadata = new EntityMetadataPart();
 
            this.PopulateMetadata(metadata, resultItem);
 
            return metadata;
        }
 
        /// <summary>Gets the origin entity code.</summary>
        /// <param name="resultItem">The result item.</param>
        /// <returns>The origin entity code.</returns>
        private EntityCode GetOriginEntityCode(IExternalSearchQueryResult<CombinedCarLookupCollection> resultItem)
        {
            return new EntityCode(EntityType.Infrastructure.User, this.GetCodeOrigin(), String.Format("{0}-{1}", resultItem.Data.DateOfBirth, resultItem.Data.Name));
        }
 
        /// <summary>Gets the code origin.</summary>
        /// <returns>The code origin</returns>
        private CodeOrigin GetCodeOrigin()
        {
            return CodeOrigin.CluedIn.CreateSpecific("danishvehicleregistry");
        }
 
        /// <summary>Populates the metadata.</summary>
        /// <param name="metadata">The metadata.</param>
        /// <param name="resultItem">The result item.</param>
        private void PopulateMetadata(IEntityMetadata metadata, IExternalSearchQueryResult<CombinedCarLookupCollection> resultItem)
        {
            var code = this.GetOriginEntityCode(resultItem);
            var car = resultItem.Data.Lookups;
 
            metadata.EntityType       = EntityType.Infrastructure.User;
            metadata.Name             = resultItem.Data.Name;

            metadata.Properties[DanishVehicleRegistryVocabularies.Person.Name]          = resultItem.Data.Name;
            metadata.Properties[DanishVehicleRegistryVocabularies.Person.DateOfBirth]   = resultItem.Data.DateOfBirth;

            for (int i = 0; i < car.Count(); i++)
            {
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.kind"]                        = car[i].Kind?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.brand"]                       = car[i].Brand?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.kmPerLiter"]                  = car[i].KmPerLiter?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.maxSpeed"]                    = car[i].MaxSpeed?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.model"]                       = car[i].Model?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.modelYear"]                   = car[i].ModelYear?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.numberPlate"]                 = car[i].NumberPlate?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.power"]                       = car[i].Power?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.vehicleIdentificationNumber"] = car[i].VehicleIdentificationNumber?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.dateOfDebt"]                  = car[i].DateOfDebt?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.initialDebt"]                 = car[i].InitialDebt?.PrintIfAvailable();
                metadata.Properties[$"{DanishVehicleRegistryVocabularies.Cars.KeyPrefix}{DanishVehicleRegistryVocabularies.Cars.KeySeparator}{i}.currency"]                    = car[i].Currency?.PrintIfAvailable();
            }

            metadata.OriginEntityCode = code;
            metadata.Codes.Add(code);
        }

        /// <summary>
        /// Wrapper around a request to ensure propper deserialization of the JSON.
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="client">An IRestClient for the request</param>
        /// <param name="parameter">The parameters for the request</param>
        /// <param name="callback">Pass additional information to the request (e.g. headers)</param>
        /// <returns>A deserialized object</returns>
        public static T JsonRequestWrapper<T>(IRestClient client, string parameter, Method method, Action<IRestRequest> callback = null)
        {
            var request = new RestRequest(parameter, method);

            callback?.Invoke(request);

            var response = client.ExecuteTaskAsync(request).Result;

            T responseData;
            if (response.StatusCode == HttpStatusCode.OK)
                responseData = JsonConvert.DeserializeObject<T>(response.Content);
            else if (response.StatusCode == HttpStatusCode.NoContent || response.StatusCode == HttpStatusCode.NotFound)
                responseData = default(T);
            else if (response.ErrorException != null)
                throw new AggregateException(response.ErrorException.Message, response.ErrorException);
            else
                throw new ApplicationException("Could not execute external search query - StatusCode:" + response.StatusCode + "; Content: " + response.Content);

            return responseData;
        }

        /// <summary>
        /// Wrapper around a request to ensure propper deserialization of the XML.
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="client">An IRestClient for the request</param>
        /// <param name="parameter">The parameters for the request</param>
        /// <param name="callback">Pass additional information to the request (e.g. headers)</param>
        /// <returns>A deserialized object</returns>
        public static T XmlRequestWrapper<T>(IRestClient client, string parameter, Method method, Action<IRestRequest> callback = null)
        {
            client.AddHandler("application/xml", new DotNetXmlDeserializer());

            var request = new RestRequest(parameter, method);

            callback?.Invoke(request);

            var response = client.ExecuteTaskAsync<T>(request).Result;

            T responseData;
            if (response.StatusCode == HttpStatusCode.OK)
                responseData = response.Data;
            else if (response.StatusCode == HttpStatusCode.NoContent || response.StatusCode == HttpStatusCode.NotFound)
                responseData = default(T);
            else if (response.ErrorException != null)
                throw new AggregateException(response.ErrorException.Message, response.ErrorException);
            else
                throw new ApplicationException("Could not execute external search query - StatusCode:" + response.StatusCode + "; Content: " + response.Content);

            return responseData;
        }
    }
}