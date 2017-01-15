using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
	public static class MusicSearchExtentions
	{
		public static async Task<SearchResponse> SearchForMusicAsync(this INewznabClient client, MusicSearchRequest request)
		{
			var result = await client.ExecuteAsync<RssResult<SearchResult>>(request);

			return new SearchResponse(result);
		}
	}
}