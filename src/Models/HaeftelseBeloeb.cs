using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseBeloeb", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class HaeftelseBeloeb
	{
		[XmlElement(ElementName = "BeloebValuta", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public BeloebValuta BeloebValuta { get; set; }
	}
}