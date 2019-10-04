// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DanishVehicleRegistryVocabulary.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the danish vehicle registry vocabulary class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Vocabularies
{
    public class DanishVehicleRegistryPersonVocabulary : SimpleVocabulary
    {
        public DanishVehicleRegistryPersonVocabulary()
        {
            this.VocabularyName = "DanishVehicleRegistry User";
            this.KeyPrefix      = "danishVehicleRegistry.user";
            this.KeySeparator   = ".";
            this.Grouping       = EntityType.Infrastructure.User;

            this.Name        = this.Add(new VocabularyKey("name"));
            this.DateOfBirth = this.Add(new VocabularyKey("dateOfBirth", VocabularyKeyDataType.DateTime));

            this.AddMapping(this.Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            this.AddMapping(this.DateOfBirth, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
        }

        public VocabularyKey Name { get; internal set; }

        public VocabularyKey DateOfBirth { get; internal set; }
    }
}