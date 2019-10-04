using Newtonsoft.Json;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	public class Item
	{
		[JsonProperty("uuid")]
		public string Id { get; set; }

		[JsonProperty("stelnummer")]
		public string VehicleIdentificationNumber { get; set; }

		[JsonProperty("registreringsnummer")]
		public string NumberPlate { get; set; }

		[JsonProperty("fabrikat")]
		public string Manufacturer { get; set; }

		[JsonProperty("model")]
		public string Model { get; set; }

		[JsonProperty("aargang")]
		public string ModelYear { get; set; }
	}
}