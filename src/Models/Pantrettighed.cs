using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "Pantrettighed", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class Pantrettighed
	{
		[XmlElement(ElementName = "RettighedIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string RettighedIdentifikator { get; set; }
		[XmlElement(ElementName = "PrioritetNummer", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string PrioritetNummer { get; set; }
	}
}