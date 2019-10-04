using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseRenteVariabel", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class HaeftelseRenteVariabel
	{
		[XmlElement(ElementName = "HaeftelseReferenceRente", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public HaeftelseReferenceRente HaeftelseReferenceRente { get; set; }
		[XmlElement(ElementName = "AftaleOmRenteniveau", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string AftaleOmRenteniveau { get; set; }
	}
}