using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "TekstAngivelse", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class TekstAngivelse
	{
		[XmlElement(ElementName = "TekstGruppe", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public TekstGruppe TekstGruppe { get; set; }
	}
}