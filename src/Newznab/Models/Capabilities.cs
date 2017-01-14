using System.Xml.Serialization;

namespace Newznab.Models
{
	[XmlRoot("caps")]
	public class Capabilities
	{
		[XmlElement("server")]
		public ServerInfo ServerInfo { get; set; }

		[XmlElement("limits")]
		public ServerLimits ServerLimits { get; set; }

		[XmlElement("retention")]
		public ServerRetention ServerRetention { get; set; }

		[XmlElement("searching")]
		public SearchingCapabilities SearchingCapabilities { get; set; }

		[XmlArray("categories"), XmlArrayItem("category")]
		public Catagory[] Categories { get; set; }

		[XmlArray("groups"), XmlArrayItem("group")]
		public UsenetGroup[] Groups { get; set; }

		[XmlArray("genres"), XmlArrayItem("genre")]
		public Genre[] Genres { get; set; }
	}
}
