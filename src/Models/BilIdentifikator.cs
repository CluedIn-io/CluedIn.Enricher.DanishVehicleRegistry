// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TinglysningLookupResponse.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the tinglysning lookup response class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
    [XmlRoot(ElementName = "BilIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
    public class BilIdentifikator
    {
        [XmlElement(ElementName = "Stelnummer", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
        public string Stelnummer { get; set; }
    }
}
