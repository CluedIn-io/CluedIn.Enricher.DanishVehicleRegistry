// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DanishVehicleRegistryDynamicVocabulary.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the danish vehicle registry dynamic vocabulary class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Vocabularies
{
	public class DanishVehicleRegistryDynamicVocabulary : DynamicVocabulary
	{
		public DanishVehicleRegistryDynamicVocabulary()
		{
			this.VocabularyName         = "DanishVehicleRegistry Car Custom Properties";
			this.KeyPrefix              = "danishVehicleRegistry.car.custom";
			this.KeySeparator           = "-";
			this.Grouping               = EntityType.Unknown;
			this.ShowInApplication      = true;
			this.ShowUrisInApplication  = false;
		}
	}
}