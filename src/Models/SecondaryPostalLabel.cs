using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "SecondaryPostalLabel", Namespace = "http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/10/31/")]
	public class SecondaryPostalLabel
	{
		[XmlElement(ElementName = "PostalAddressFirstLineText", Namespace = "http://rep.oio.dk/ebxml/xml/schemas/dkcc/2005/05/19/")]
		public string PostalAddressFirstLineText { get; set; }
		[XmlElement(ElementName = "PostalAddressSecondLineText", Namespace = "http://rep.oio.dk/ebxml/xml/schemas/dkcc/2005/05/19/")]
		public string PostalAddressSecondLineText { get; set; }
		[XmlElement(ElementName = "PostalAddressThirdLineText", Namespace = "http://rep.oio.dk/ebxml/xml/schemas/dkcc/2005/05/19/")]
		public string PostalAddressThirdLineText { get; set; }
	}
}