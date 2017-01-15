using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
	public static class SearchExtentions
	{
		public static async Task<SearchResponse> SearchAsync(this INewznabClient client, SearchRequest request)
		{
			var result = await client.ExecuteAsync<RssResult<SearchResult>>(request);

			return new SearchResponse(result);
		}
	}
}