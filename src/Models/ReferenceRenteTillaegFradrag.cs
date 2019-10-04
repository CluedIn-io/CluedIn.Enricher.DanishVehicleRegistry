using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "ReferenceRenteTillaegFradrag", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class ReferenceRenteTillaegFradrag
	{
		[XmlElement(ElementName = "TillaegFradragIndikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string TillaegFradragIndikator { get; set; }
		[XmlElement(ElementName = "Procentsats", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string Procentsats { get; set; }
		[XmlElement(ElementName = "FastVariabelIndikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string FastVariabelIndikator { get; set; }
	}
}