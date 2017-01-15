using System;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
	public class SearchResponse
	{
		private readonly RssResult<SearchResult> rssResult;

		public SearchResponse(RssResult<SearchResult> rssResult)
		{
			this.rssResult = rssResult;
		}

		public Int32 TotalResults => this.rssResult.Channel.Response.Total;

		public Int32 CurrentOffset => this.rssResult.Channel.Response.Offset;

		public SearchResult[] Items => this.rssResult.Channel.Items;
	}
}