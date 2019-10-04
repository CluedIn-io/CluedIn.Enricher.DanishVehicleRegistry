using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "BilStruktur", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class BilStruktur
	{
		[XmlElement(ElementName = "BilMaerke", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public BilMaerke BilMaerke { get; set; }
		[XmlElement(ElementName = "RegistreringsnummerTekst", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string RegistreringsnummerTekst { get; set; }
		[XmlElement(ElementName = "FoersteRegistreringsAar", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string FoersteRegistreringsAar { get; set; }
	}
}