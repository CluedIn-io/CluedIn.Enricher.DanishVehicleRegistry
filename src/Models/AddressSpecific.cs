using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "AddressSpecific", Namespace = "http://rep.oio.dk/xkom.dk/xml/schemas/2006/01/06/")]
	public class AddressSpecific
	{
		[XmlElement(ElementName = "AddressAccess", Namespace = "http://rep.oio.dk/xkom.dk/xml/schemas/2005/03/15/")]
		public AddressAccess AddressAccess { get; set; }
	}
}