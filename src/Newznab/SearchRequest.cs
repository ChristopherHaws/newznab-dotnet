using System;
using System.Collections.Generic;
using System.Net;

namespace Newznab
{
	/// <summary>
	/// Represents a request to search the index for items matching the search criteria. On successful search the response
	/// contains a list of found items. Even if search matches nothing, an empty response set is created and returned.
	/// </summary>
	/// <seealso cref="Newznab.NewznabWebRequest" />
	public class SearchRequest : NewznabWebRequest
	{
		public SearchRequest()
			: this("search")
		{
		}

		protected SearchRequest(String command)
			: base(command)
		{
		}

		/// <summary>
		/// Gets or sets the search input. This value is case insensitive.
		/// </summary>
		public virtual String SearchInput
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
		/// Gets or sets the list of usenet groups to search.
		/// </summary>
		public virtual IEnumerable<String> Group
		{
			get
			{
				return this["group"]?.Split(new [] {','}, StringSplitOptions.RemoveEmptyEntries);
			}
			set
			{
				this["group"] = String.Join(",", value);
			}
		}

		/// <summary>
		/// Gets or sets the categories to search. The categories will be OR'ed together, meaning an item matching the
		/// <see cref="SearchInput"/> in any of the specified categories is considered a match and is returned.
		/// 
		/// If a supplied category is not supported by the server, it will be skipped.
		/// </summary>
		public virtual IEnumerable<String> Categories
		{
			get
			{
				return this["cat"]?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			}
			set
			{
				this["cat"] = String.Join(",", value);
			}
		}

		/// <summary>
		/// Gets or sets the requested extended attributes.
		/// </summary>
		public virtual IEnumerable<String> Attributes
		{
			get
			{
				return this["attrs"]?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			}
			set
			{
				this["attrs"] = String.Join(",", value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether to return all extended attributes.
		/// If this value is true, then <see cref="Attributes"/> is ignored.
		/// </summary>
		public virtual Boolean ReturnAllExtendedAttributes
		{
			get
			{
				return this["extended"] == "1";
			}
			set
			{
				this["extended"] = value ? "1" : "0";
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether to delete the item from a users cart on download.
		/// </summary>
		public virtual Boolean DeleteFromCartOnDownload
		{
			get
			{
				return this["del"] == "1";
			}
			set
			{
				this["del"] = value ? "1" : "0";
			}
		}

		/// <summary>
		/// Gets or sets the maximum age, in days, for an item.
		/// </summary>
		public virtual Int32 MaxAge
		{
			get
			{
				return Convert.ToInt32(this["maxage"]);
			}
			set
			{
				this["maxage"] = value.ToString();
			}
		}

		/// <summary>
		/// Gets or sets the zero based query offset that is used for pageing the results. If a search finds more matches than the server
		/// is capable of transmitting in a single response, the response needs to be split into several responses.
		/// </summary>
		public virtual Int32 ResultOffset
		{
			get
			{
				return Convert.ToInt32(this["offset"]);
			}
			set
			{
				this["offset"] = value.ToString();
			}
		}

		/// <summary>
		/// Gets or sets the upper limit for the number of items to be returned.
		/// </summary>
		public virtual Int32 MaxResults
		{
			get
			{
				return Convert.ToInt32(this["limit"]);
			}
			set
			{
				this["limit"] = value.ToString();
			}
		}
	}
}
