// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DanishVehicleRegistryVocabularies.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the danish vehicle registry vocabularies class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Vocabularies
{
    public static class DanishVehicleRegistryVocabularies
    {
        public static DanishVehicleRegistryDynamicVocabulary Cars { get; } = new DanishVehicleRegistryDynamicVocabulary();
        public static DanishVehicleRegistryPersonVocabulary Person { get; } = new DanishVehicleRegistryPersonVocabulary();
    }
}
