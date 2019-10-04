using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "FuldmagtHaverInformation", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class FuldmagtHaverInformation
	{
		[XmlElement(ElementName = "VirksomhedSimpelIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public VirksomhedSimpelIdentifikator VirksomhedSimpelIdentifikator { get; set; }
		[XmlElement(ElementName = "SecondaryPostalLabel", Namespace = "http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/10/31/")]
		public SecondaryPostalLabel SecondaryPostalLabel { get; set; }
	}
}