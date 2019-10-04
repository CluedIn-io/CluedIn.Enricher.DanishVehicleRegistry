using System.Xml.Serialization;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	[XmlRoot(ElementName = "BilSummariskHentResultat", Namespace = "http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/")]
	public class BilSummariskHentResultat
	{
		[XmlElement(ElementName = "BilSummarisk", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public BilSummarisk BilSummarisk { get; set; }
		[XmlElement(ElementName = "UdskriftDatoTid", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string UdskriftDatoTid { get; set; }
		[XmlElement(ElementName = "AnmeldelseModtagetIndikator", Namespace = "http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/")]
		public string AnmeldelseModtagetIndikator { get; set; }
		[XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Signature Signature { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "ns", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns { get; set; }
		[XmlAttribute(AttributeName = "ns1", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns1 { get; set; }
		[XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns2 { get; set; }
		[XmlAttribute(AttributeName = "ns3", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns3 { get; set; }
		[XmlAttribute(AttributeName = "ns4", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns4 { get; set; }
		[XmlAttribute(AttributeName = "ns5", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns5 { get; set; }
		[XmlAttribute(AttributeName = "ns6", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns6 { get; set; }
		[XmlAttribute(AttributeName = "ns7", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns7 { get; set; }
		[XmlAttribute(AttributeName = "ns8", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns8 { get; set; }
		[XmlAttribute(AttributeName = "ns9", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns9 { get; set; }
		[XmlAttribute(AttributeName = "ns10", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns10 { get; set; }
		[XmlAttribute(AttributeName = "xd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xd { get; set; }
	}
}