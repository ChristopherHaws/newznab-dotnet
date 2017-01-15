using System;

namespace Newznab
{
	/// <summary>
	/// Represents a request to search the index in the TV category for items matching the search criteria. 
	/// </summary>
	/// <seealso cref="SearchRequest" />
	public class TvShowSearchRequest : SearchRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TvShowSearchRequest"/> class.
		/// </summary>
		public TvShowSearchRequest()
			: base("tvsearch")
		{
		}

		/// <summary>
		/// Gets or sets the season number, e.g 13 for season 13.
		/// </summary>
		public Int32 Season
		{
			get
			{
				return Convert.ToInt32(this["season"].TrimStart('S'));
			}
			set
			{
				this["season"] = $"S{value.ToString().PadLeft(2, '0')}";
			}
		}

		/// <summary>
		/// Gets or sets the episode number, e.g 13 for episode 13.
		/// </summary>
		public Int32 Episode
		{
			get
			{
				return Convert.ToInt32(this["ep"].TrimStart('S'));
			}
			set
			{
				this["ep"] = $"E{value.ToString().PadLeft(2, '0')}";
			}
		}

		/// <summary>
		/// Gets or sets the TVRage id of the item being queried.
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
