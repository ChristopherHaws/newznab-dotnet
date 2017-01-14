using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class NewznabResponse
	{
		[XmlAttribute("offset")]
		public Int32 Offset { get; set; }

		[XmlAttribute("total")]
		public Int32 Total { get; set; }
	}
}
