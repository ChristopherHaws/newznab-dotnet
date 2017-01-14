using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class UsenetGroup
	{
		private String lastUpdatedString;

		[XmlAttribute("id")]
		public Int32 Id { get; set; }

		[XmlAttribute("name")]
		public String Name { get; set; }

		[XmlAttribute("description")]
		public String Description { get; set; }

		[XmlIgnore]
		public DateTime LastUpdated { get; set; }

		[XmlAttribute("lastupdate")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public String LastUpdatedString
		{
			get
			{
				return this.lastUpdatedString;
			}
			set
			{
				this.lastUpdatedString = value;
				this.LastUpdated = Convert.ToDateTime(value);
			}
		}
	}
}
