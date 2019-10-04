using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseSummariskSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class HaeftelseSummariskSamling
	{
		[XmlElement(ElementName = "HaeftelseSummarisk", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public HaeftelseSummarisk HaeftelseSummarisk { get; set; }
	}
}