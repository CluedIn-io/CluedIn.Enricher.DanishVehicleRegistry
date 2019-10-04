using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "Underpantrettighed", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class Underpantrettighed
	{
		[XmlElement(ElementName = "DokumentRevisionIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public DokumentRevisionIdentifikator DokumentRevisionIdentifikator { get; set; }
		[XmlElement(ElementName = "DokumentAlias", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public DokumentAlias DokumentAlias { get; set; }
		[XmlElement(ElementName = "RettighedIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string RettighedIdentifikator { get; set; }
		[XmlElement(ElementName = "UnderpantBeloeb", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public UnderpantBeloeb UnderpantBeloeb { get; set; }
		[XmlElement(ElementName = "PrioritetNummer", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string PrioritetNummer { get; set; }
		[XmlElement(ElementName = "UnderpanthaverInformationSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public UnderpanthaverInformationSamling UnderpanthaverInformationSamling { get; set; }
	}
}