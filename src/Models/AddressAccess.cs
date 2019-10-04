using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "AddressAccess", Namespace = "http://rep.oio.dk/xkom.dk/xml/schemas/2005/03/15/")]
	public class AddressAccess
	{
		[XmlElement(ElementName = "MunicipalityCode", Namespace = "http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/03/18/")]
		public string MunicipalityCode { get; set; }
		[XmlElement(ElementName = "StreetCode", Namespace = "http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/03/18/")]
		public string StreetCode { get; set; }
		[XmlElement(ElementName = "StreetBuildingIdentifier", Namespace = "http://rep.oio.dk/ebxml/xml/schemas/dkcc/2003/02/13/")]
		public string StreetBuildingIdentifier { get; set; }
	}
}