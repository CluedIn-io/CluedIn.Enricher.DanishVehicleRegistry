// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinedCarLookup.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the combined car lookup class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	public class CombinedCarLookup
    {
        public string Kind { get; set; }
        public string ModelYear { get; set; }
        public string MaxSpeed { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Power { get; set; }
        public string KmPerLiter { get; set; }
        public string NumberPlate { get; set; }
        public string VehicleIdentificationNumber { get; set; }

        public string DateOfDebt { get; set; }
        public string InitialDebt { get; set; }
        public string Currency { get; set; }
    }
}
