using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class Genre
	{
		[XmlAttribute("id")]
		public Int32 Id { get; set; }

		[XmlAttribute("categoryid")]
		public Int32 CategoryId { get; set; }

		[XmlAttribute("name")]
		public String Name { get; set; }
	}
}
