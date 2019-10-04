using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseSaerligeLaanevilkaarstypeSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class HaeftelseSaerligeLaanevilkaarstypeSamling
	{
		[XmlElement(ElementName = "HaeftelseSaerligeLaanevilkaarstype", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string HaeftelseSaerligeLaanevilkaarstype { get; set; }
	}
}