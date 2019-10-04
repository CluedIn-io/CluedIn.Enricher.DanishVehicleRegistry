using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "VirksomhedSimpelIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class VirksomhedSimpelIdentifikator
	{
		[XmlElement(ElementName = "LegalUnitName", Namespace = "http://rep.oio.dk/cvr.dk/xml/schemas/2005/03/22/")]
		public string LegalUnitName { get; set; }
		[XmlElement(ElementName = "CVRnumberIdentifier", Namespace = "http://rep.oio.dk/cvr.dk/xml/schemas/2005/03/22/")]
		public string CVRnumberIdentifier { get; set; }
	}
}