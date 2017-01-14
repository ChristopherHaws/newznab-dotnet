using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class NewznabAttribute
	{
		[XmlAttribute("name")]
		public String Name { get; set; }

		[XmlAttribute("value")]
		public String Value { get; set; }
	}
}
