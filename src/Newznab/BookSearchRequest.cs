using System;

namespace Newznab
{
	/// <summary>
	/// Represents a request to search the index in the book category for items matching the search criteria. 
	/// </summary>
	/// <seealso cref="SearchRequest" />
	public class BookSearchRequest : SearchRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BookSearchRequest"/> class.
		/// </summary>
		public BookSearchRequest()
			: base("book")
		{
		}

		/// <summary>
		/// Gets or sets the name of the book.
		/// </summary>
		public String BookName
		{
			get
			{
				return this["title"];
			}
			set
			{
				this["title"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the author of the book.
		/// </summary>
		public String AuthorName
		{
			get
			{
				return this["author"];
			}
			set
			{
				this["author"] = value;
			}
		}
	}
}