using System;
using System.Net;

namespace Newznab
{
	public abstract class SearchRequest : NewznabWebRequest
	{
		protected SearchRequest(String command)
			: base(command)
		{
		}

		/// <summary>
		/// Search input. Case insensitive.
		/// </summary>
		public virtual String Name
		{
			get
			{
				return WebUtility.UrlDecode(this["q"]);
			}
			set
			{
				this["q"] = WebUtility.UrlEncode(value);
			}
		}

		/// <summary>
		/// List of usenet groups to search delimited by ","
		/// </summary>
		public virtual String Group
		{
			get
			{
				return this["q"];
			}
			set
			{
				this["q"] = value;
			}
		}

		/// <summary>
		/// List of categories to search delimited by ","
		/// </summary>
		public virtual String Categories
		{
			get
			{
				return this["cat"];
			}
			set
			{
				this["cat"] = value;
			}
		}
	}
}
