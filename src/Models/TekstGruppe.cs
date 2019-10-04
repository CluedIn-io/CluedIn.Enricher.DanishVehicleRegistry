using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "TekstGruppe", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class TekstGruppe
	{
		[XmlElement(ElementName = "Afsnit", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string Afsnit { get; set; }
	}
}