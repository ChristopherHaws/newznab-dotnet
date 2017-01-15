using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
	public static class TvShowExtentions
	{
		public static async Task<SearchResponse> SearchForTvShowAsync(this INewznabClient client, TvShowSearchRequest request)
		{
			var result = await client.ExecuteAsync<RssResult<SearchResult>>(request);

			return new SearchResponse(result);
		}
	}
}
