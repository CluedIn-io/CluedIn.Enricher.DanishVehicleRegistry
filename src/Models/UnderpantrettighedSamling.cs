using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "UnderpantrettighedSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class UnderpantrettighedSamling
	{
		[XmlElement(ElementName = "Underpantrettighed", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public Underpantrettighed Underpantrettighed { get; set; }
	}
}