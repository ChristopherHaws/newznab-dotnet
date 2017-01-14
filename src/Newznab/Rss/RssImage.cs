using System;
using System.Xml.Serialization;

namespace Newznab.Rss
{
	/// <summary>
	/// The image allows an image to be displayed when aggregators present a feed.
	/// </summary>
	public class RssImage
	{
		/// <summary>
		/// Gets or sets the url to the image. Required.
		/// </summary>
		[XmlElement("url")]
		public String Url { get; set; }

		/// <summary>
		/// Gets or sets the text to display if the image could not be shown. Required.
		/// </summary>
		[XmlElement("title")]
		public String Title { get; set; }

		/// <summary>
		/// Gets or sets the hyperlink to the website that offers the channel. Required.
		/// </summary>
		[XmlElement("link")]
		public String Link { get; set; }

		/// <summary>
		/// Gets or sets the description. Optional.
		/// </summary>
		[XmlElement("description")]
		public String Description { get; set; }
	}
}
