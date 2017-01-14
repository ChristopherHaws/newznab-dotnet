using System;
using System.Xml.Serialization;
using Newznab.Models;

namespace Newznab.Rss
{
	/// <summary>
	/// The RSS channel describes the RSS feed.
	/// </summary>
	public class RssChannel<TItem>
		where TItem : RssItem
	{
		[XmlElement("link", Namespace = NewznabNamespace.Atom)]
		public AtomLink AtomLink { get; set; }

		[XmlElement("title")]
		public String Title { get; set; }

		[XmlElement("description")]
		public String Description { get; set; }

		[XmlElement("link")]
		public String Link { get; set; }

		/// <summary>
		/// Gets or sets the language that was used to write the document.
		/// </summary>
		[XmlElement("language")]
		public String Language { get; set; }

		[XmlElement("webMaster")]
		public String WebMaster { get; set; }

		[XmlElement("image")]
		public RssImage Image { get; set; }

		[XmlElement("response", Namespace = NewznabNamespace.Newznab)]
		public NewznabResponse Response { get; set; }

		[XmlElement("item")]
		public TItem[] Items { get; set; }
	}
}
