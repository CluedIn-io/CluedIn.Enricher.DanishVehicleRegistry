using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "HaeftelseSummarisk", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class HaeftelseSummarisk
	{
		[XmlElement(ElementName = "DokumentRevisionIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public DokumentRevisionIdentifikator DokumentRevisionIdentifikator { get; set; }
		[XmlElement(ElementName = "TinglysningsDato", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string TinglysningsDato { get; set; }
		[XmlElement(ElementName = "Pantrettighed", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public Pantrettighed Pantrettighed { get; set; }
		[XmlElement(ElementName = "DokumentAlias", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public DokumentAlias DokumentAlias { get; set; }
		[XmlElement(ElementName = "BilHaeftelseTypeTekst", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string BilHaeftelseTypeTekst { get; set; }
		[XmlElement(ElementName = "HaeftelsePantebrevFormularLovpligtigKode", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string HaeftelsePantebrevFormularLovpligtigKode { get; set; }
		[XmlElement(ElementName = "DokumentOverfoertIndikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string DokumentOverfoertIndikator { get; set; }
		[XmlElement(ElementName = "KreditorInformationSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public KreditorInformationSamling KreditorInformationSamling { get; set; }
		[XmlElement(ElementName = "DebitorInformationSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public DebitorInformationSamling DebitorInformationSamling { get; set; }
		[XmlElement(ElementName = "ImplicitFuldmagtSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public ImplicitFuldmagtSamling ImplicitFuldmagtSamling { get; set; }
		[XmlElement(ElementName = "UnderpantrettighedSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public UnderpantrettighedSamling UnderpantrettighedSamling { get; set; }
		[XmlElement(ElementName = "HaeftelseBeloeb", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public HaeftelseBeloeb HaeftelseBeloeb { get; set; }
		[XmlElement(ElementName = "HaeftelseRente", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public HaeftelseRente HaeftelseRente { get; set; }
		[XmlElement(ElementName = "HaeftelseSaerligeLaanevilkaarstypeSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public HaeftelseSaerligeLaanevilkaarstypeSamling HaeftelseSaerligeLaanevilkaarstypeSamling { get; set; }
		[XmlElement(ElementName = "TillaegstekstSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public TillaegstekstSamling TillaegstekstSamling { get; set; }
		[XmlElement(ElementName = "TinglysningAfgiftBetalt", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string TinglysningAfgiftBetalt { get; set; }
		[XmlElement(ElementName = "TinglysningAfgiftOverfoerselIndikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string TinglysningAfgiftOverfoerselIndikator { get; set; }
		[XmlElement(ElementName = "BilStruktur", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public BilStruktur BilStruktur { get; set; }
	}
}