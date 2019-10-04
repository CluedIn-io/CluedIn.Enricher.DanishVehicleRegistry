using System.Collections.Generic;
using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "DebitorInformationSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
	public class DebitorInformationSamling
	{
		[XmlElement(ElementName = "RolleInformation", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public List<RolleInformation> RolleInformation { get; set; }
	}
}