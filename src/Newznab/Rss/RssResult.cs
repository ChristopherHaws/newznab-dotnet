using System.Xml.Serialization;

namespace Newznab.Rss
{
	[XmlRoot("rss")]
	public class RssResult<TItem>
		where TItem : RssItem
	{
		[XmlElement("channel")]
		public RssChannel<TItem> Channel { get; set; }
	}
}
