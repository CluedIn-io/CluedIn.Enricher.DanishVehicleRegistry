using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "RolleInformation", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class RolleInformation
	{
		[XmlElement(ElementName = "PersonSimpelIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public PersonSimpelIdentifikator PersonSimpelIdentifikator { get; set; }
		[XmlElement(ElementName = "AddressSpecific", Namespace = "http://rep.oio.dk/xkom.dk/xml/schemas/2006/01/06/")]
		public AddressSpecific AddressSpecific { get; set; }
		[XmlElement(ElementName = "VirksomhedSimpelIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public VirksomhedSimpelIdentifikator VirksomhedSimpelIdentifikator { get; set; }
	}
}