using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Newznab.Models
{
	public class SearchCapability
	{
		[XmlIgnore]
		public Boolean Available { get; set; }

		[XmlAttribute("available")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public String AvailableString
		{
			get
			{
				return this.Available ? "Yes" : "No";
			}
			set
			{
				switch (value.ToLower())
				{
					case "yes":
					case "true":
					case "1":
						this.Available = true;
						break;
					case "no":
					case "false":
					case "0":
						this.Available = false;
						break;
					default: throw new ArgumentOutOfRangeException();
				}
			}
		}

		[XmlIgnore]
		public String[] SupportedParameters { get; set; } = new String[0];

		[XmlAttribute("supportedParams")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public String SupportedParametersString
		{
			get
			{
				return String.Join(",", this.SupportedParameters);
			}
			set
			{
				this.SupportedParameters = value?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			}
		}
	}
}
