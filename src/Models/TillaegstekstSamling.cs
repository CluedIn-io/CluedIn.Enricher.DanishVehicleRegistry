using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "TillaegstekstSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class TillaegstekstSamling
	{
		[XmlElement(ElementName = "TekstAngivelse", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public TekstAngivelse TekstAngivelse { get; set; }
	}
}