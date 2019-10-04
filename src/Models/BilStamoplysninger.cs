using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "BilStamoplysninger", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class BilStamoplysninger
	{
		[XmlElement(ElementName = "BilIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public BilIdentifikator BilIdentifikator { get; set; }
		[XmlElement(ElementName = "BilStruktur", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public BilStruktur BilStruktur { get; set; }
	}
}