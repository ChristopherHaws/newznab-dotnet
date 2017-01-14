using System;
using System.Collections.Generic;
using System.Linq;
using Newznab.Models;

namespace Newznab
{
	/// <summary>
	/// Represents a request to search the index in the music category for items matching an the search criteria. 
	/// </summary>
	/// <seealso cref="Newznab.SearchRequest" />
	public class MusicSearchRequest : SearchRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MusicSearchRequest"/> class.
		/// </summary>
		public MusicSearchRequest()
			: base("music")
		{
		}

		/// <summary>
		/// Gets or sets the name of the album.
		/// </summary>
		public String AlbumName
		{
			get
			{
				return this["album"];
			}
			set
			{
				this["album"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the artist.
		/// </summary>
		public String ArtistName
		{
			get
			{
				return this["artist"];
			}
			set
			{
				this["artist"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the publisher or label.
		/// </summary>
		public String PublisherName
		{
			get
			{
				return this["label"];
			}
			set
			{
				this["label"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the track.
		/// </summary>
		public String TrackName
		{
			get
			{
				return this["track"];
			}
			set
			{
				this["track"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the year of the release.
		/// </summary>
		public String Year
		{
			get
			{
				return this["year"];
			}
			set
			{
				if (value != null && value.Length != 4)
				{
					throw new InvalidOperationException("Year must be a 4 digit year.");
				}

				this["year"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the music genre id's. See <see cref="Capabilities"/> for available genres.
		/// </summary>
		public IList<Int32> GenreIds
		{
			get
			{
				return this["genre"]
					.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(x => Convert.ToInt32((String) x))
					.ToList();
			}
			set
			{
				this["genre"] = String.Join(",", value);
			}
		}
	}
}