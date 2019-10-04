using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "UnderpantBeloeb", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class UnderpantBeloeb
	{
		[XmlElement(ElementName = "BeloebVaerdi", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string BeloebVaerdi { get; set; }
		[XmlElement(ElementName = "ValutaKode", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string ValutaKode { get; set; }
	}
}