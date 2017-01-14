using System;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class ServerLimits
	{
		[XmlAttribute("max")]
		public Int32 MaxResults { get; set; }

		[XmlAttribute("default")]
		public Int32 DefaultResults { get; set; }
	}
}
