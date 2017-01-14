using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Newznab.Rss
{
	public class RssItem
	{
		private String publishedDateString;

		[XmlElement("title")]
		public String Title { get; set; }

		[XmlElement("link")]
		public String Link { get; set; }

		[XmlElement("description")]
		public String Description { get; set; }

		[XmlElement("guid")]
		public String Guid { get; set; }

		[XmlElement("comments")]
		public String Comments { get; set; }

		[XmlIgnore]
		public DateTime PublishedDate { get; set; }

		[XmlElement("pubDate")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public String PublishedDateString
		{
			get
			{
				return this.publishedDateString;
			}
			set
			{
				this.publishedDateString = value;
				this.PublishedDate = Convert.ToDateTime(value);
			}
		}
		
		[XmlElement("enclosure")]
		public RssFileAttachment FileAdAttachment { get; set; }
	}
}
