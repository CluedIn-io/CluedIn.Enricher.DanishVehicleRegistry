using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "BilMaerke", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class BilMaerke
	{
		[XmlElement(ElementName = "BilFabrikatTekst", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string BilFabrikatTekst { get; set; }
		[XmlElement(ElementName = "BilModelTekst", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string BilModelTekst { get; set; }
		[XmlElement(ElementName = "BilVariantTekst", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string BilVariantTekst { get; set; }
	}
}