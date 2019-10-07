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
}