using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "DokumentAlias", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class DokumentAlias
	{
		[XmlElement(ElementName = "DokumentAliasIdentifikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string DokumentAliasIdentifikator { get; set; }
	}
}