// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DanishVehicleRegistryResponse.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the danish vehicle registry response class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
    public class TinglysningSearchResponse
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
}
