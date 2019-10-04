using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "ImplicitFuldmagt", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class ImplicitFuldmagt
	{
		[XmlElement(ElementName = "FuldmagtHaverInformation", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public FuldmagtHaverInformation FuldmagtHaverInformation { get; set; }
		[XmlElement(ElementName = "FuldmagtOmfangIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string FuldmagtOmfangIdentifikator { get; set; }
	}
}