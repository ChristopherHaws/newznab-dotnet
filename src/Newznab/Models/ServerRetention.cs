using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class ServerRetention
	{
		[XmlAttribute("days")]
		public Int32 Days { get; set; }
	}
}
