using System;

namespace Newznab
{
	public class TvShowSearchRequest : SearchRequest
	{
		public TvShowSearchRequest()
			: base("tvsearch")
		{
		}

		/// <summary>
		/// Season string, e.g S13 or 13 for the item being queried.
		/// </summary>
		public String Season
		{
			get
			{
				return this["season"];
			}
			set
			{
				this["season"] = value;
			}
		}

		/// <summary>
		/// Episode string, e.g E13 or 13 for the item being queried.
		/// </summary>
		public String Episode
		{
			get
			{
				return this["ep"];
			}
			set
			{
				this["ep"] = value;
			}
		}

		/// <summary>
		/// TVRage id of the item being queried.
		/// </summary>
		public String TvRageId
		{
			get
			{
				return this["rid"];
			}
			set
			{
				this["rid"] = value;
			}
		}
	}
}
