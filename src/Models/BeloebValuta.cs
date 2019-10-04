﻿using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "BeloebValuta", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
	public class BeloebValuta
	{
		[XmlElement(ElementName = "BeloebVaerdi", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string BeloebVaerdi { get; set; }
		[XmlElement(ElementName = "ValutaKode", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/model/1/")]
		public string ValutaKode { get; set; }
	}
}