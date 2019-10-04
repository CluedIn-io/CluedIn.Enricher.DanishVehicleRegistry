// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinedCarLookup.cs" company="Clued In">
//   Copyright (c) 2018 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the combined car lookup class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
    public class CombinedCarLookupCollection
    {
        public CombinedCarLookupCollection(string name, string dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Lookups = new List<CombinedCarLookup>();
        }

        public List<CombinedCarLookup> Lookups { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
    }

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
