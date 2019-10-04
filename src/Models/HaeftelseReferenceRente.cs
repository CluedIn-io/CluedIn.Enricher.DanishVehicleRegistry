using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseReferenceRente", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class HaeftelseReferenceRente
	{
		[XmlElement(ElementName = "ReferenceRenteNavn", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string ReferenceRenteNavn { get; set; }
		[XmlElement(ElementName = "ReferenceRenteTillaegFradrag", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public ReferenceRenteTillaegFradrag ReferenceRenteTillaegFradrag { get; set; }
	}
}