using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseRente", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class HaeftelseRente
	{
		[XmlElement(ElementName = "HaeftelseRenteVariabel", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public HaeftelseRenteVariabel HaeftelseRenteVariabel { get; set; }
	}
}