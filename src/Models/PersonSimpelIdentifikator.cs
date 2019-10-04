using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "PersonSimpelIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class PersonSimpelIdentifikator
	{
		[XmlElement(ElementName = "PersonName", Namespace = "http://rep.oio.dk/itst.dk/xml/schemas/2006/01/17/")]
		public string PersonName { get; set; }
		[XmlElement(ElementName = "BirthDate", Namespace = "http://rep.oio.dk/ebxml/xml/schemas/dkcc/2005/03/15/")]
		public string BirthDate { get; set; }
	}
}