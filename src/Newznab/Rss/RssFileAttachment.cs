using System;
using System.Xml.Serialization;

namespace Newznab.Rss
{
	public class RssFileAttachment
	{
		[XmlAttribute("url")]
		public String Url { get; set; }

		[XmlAttribute("length")]
		public Int64 Length { get; set; }

		[XmlAttribute("type")]
		public String Type { get; set; }
	}
}
