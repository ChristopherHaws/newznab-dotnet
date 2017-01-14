using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class ServerInfo
	{
		[XmlAttribute("appversion")]
		public String AppVersion { get; set; }

		[XmlAttribute("version")]
		public String Version { get; set; }

		[XmlAttribute("title")]
		public String Title { get; set; }

		[XmlAttribute("strapline")]
		public String StrapLine { get; set; }

		[XmlAttribute("email")]
		public String Email { get; set; }

		[XmlAttribute("url")]
		public String Url { get; set; }

		[XmlAttribute("image")]
		public String Image { get; set; }
	}
}
