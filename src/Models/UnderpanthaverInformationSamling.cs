using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "UnderpanthaverInformationSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class UnderpanthaverInformationSamling
	{
		[XmlElement(ElementName = "RolleInformation", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public RolleInformation RolleInformation { get; set; }
	}
}