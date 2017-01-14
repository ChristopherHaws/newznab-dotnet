using System;
using System.Xml.Serialization;

namespace Newznab.Rss
{
	public class AtomLink
	{
		[XmlAttribute("href")]
		public String Url { get; set; }

		[XmlAttribute("rel")]
		public String Rel { get; set; }

		[XmlAttribute("type")]
		public String Type { get; set; }
	}
}
