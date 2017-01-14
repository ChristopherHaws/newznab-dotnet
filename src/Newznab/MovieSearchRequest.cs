using System;

namespace Newznab
{
	/// <summary>
	/// Represents a request to search the index in the Movie category for items matching an IMDb ID or the search criteria. 
	/// </summary>
	/// <seealso cref="Newznab.SearchRequest" />
	public class MovieSearchRequest : SearchRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MovieSearchRequest"/> class.
		/// </summary>
		public MovieSearchRequest()
			: base("movie")
		{
		}

		/// <summary>
		/// Gets or sets the IMDb ID of the item being queried.
		/// </summary>
		public String ImdbId
		{
			get
			{
				return this["imdbid"];
			}
			set
			{
				this["imdbid"] = value;
			}
		}
	}
}