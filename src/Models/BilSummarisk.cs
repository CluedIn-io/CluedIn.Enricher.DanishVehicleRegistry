using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "BilSummarisk", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class BilSummarisk
	{
		[XmlElement(ElementName = "BilStamoplysninger", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public BilStamoplysninger BilStamoplysninger { get; set; }
		[XmlElement(ElementName = "HaeftelseSummariskSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public HaeftelseSummariskSamling HaeftelseSummariskSamling { get; set; }
		[XmlElement(ElementName = "ModelId", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string ModelId { get; set; }
	}
}