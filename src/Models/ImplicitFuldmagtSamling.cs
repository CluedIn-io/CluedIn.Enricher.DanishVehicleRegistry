using System.Collections.Generic;
using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "ImplicitFuldmagtSamling", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class ImplicitFuldmagtSamling
	{
		[XmlElement(ElementName = "ImplicitFuldmagt", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public List<ImplicitFuldmagt> ImplicitFuldmagt { get; set; }
	}
}