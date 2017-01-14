using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class SubCatagory
	{
		[XmlAttribute("id")]
		public Int32 Id { get; set; }

		[XmlAttribute("name")]
		public String Name { get; set; }

		[XmlAttribute("description")]
		public String Description { get; set; }
	}
}
