using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "DokumentRevisionIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class DokumentRevisionIdentifikator
	{
		[XmlElement(ElementName = "DokumentIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string DokumentIdentifikator { get; set; }
		[XmlElement(ElementName = "RevisionNummer", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string RevisionNummer { get; set; }
	}
}