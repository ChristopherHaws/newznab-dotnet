using System;
using System.Xml.Serialization;
using Newznab.Rss;

namespace Newznab.Models
{
	public class SearchResult : RssItem
	{
		[XmlElement("category")]
		public String Category { get; set; }

		[XmlElement("attr", Namespace = NewznabNamespace.Newznab)]
		public NewznabAttribute[] Attributes { get; set; }
	}
}
