using System.Xml.Serialization;

namespace Newznab.Models
{
	public class SearchingCapabilities
	{
		[XmlElement("search")]
		public SearchCapability SearchCapability { get; set; } = new SearchCapability();

		[XmlElement("tv-search")]
		public SearchCapability TvSearchCapability { get; set; } = new SearchCapability();

		[XmlElement("movie-search")]
		public SearchCapability MovieSearchCapability { get; set; } = new SearchCapability();

		[XmlElement("audio-search")]
		public SearchCapability AudioSearchCapability { get; set; } = new SearchCapability();

		[XmlElement("music-search")]
		public SearchCapability MusicSearchCapability { get; set; } = new SearchCapability();

		[XmlElement("book-search")]
		public SearchCapability BookSearchCapability { get; set; } = new SearchCapability();
	}
}
