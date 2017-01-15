using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
	public static class BookSearchExtentions
    {
		public static async Task<SearchResponse> SearchForBookAsync(this INewznabClient client, BookSearchRequest request)
		{
			var result = await client.ExecuteAsync<RssResult<SearchResult>>(request);

			return new SearchResponse(result);
		}
	}
}
