using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
    public static class MovieSearchExtentions
    {
		public static async Task<SearchResponse> SearchForMovieAsync(this INewznabClient client, MovieSearchRequest request)
		{
			var result = await client.ExecuteAsync<RssResult<SearchResult>>(request);

			return new SearchResponse(result);
		}
	}
}
