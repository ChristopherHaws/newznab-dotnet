using System;
using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;

namespace Newznab
{
    public class NewznabClient
    {
	    private readonly String uri;
	    private readonly String apiKey;
	    private readonly NewznabWebRequestExecutor requestExecutor;

	    private Capabilities capabilities;

		public NewznabClient(String uri, String apiKey)
	    {
		    this.uri = uri;
		    this.apiKey = apiKey;
		    this.requestExecutor = new NewznabWebRequestExecutor();
		}
		
		public async Task<Capabilities> GetCapabilitiesAsync(Boolean forceRefresh = false)
		{
			if (this.capabilities != null && !forceRefresh)
			{
				return this.capabilities;
			}

			var request = new CapabilitiesRequest();

			this.capabilities = await this.requestExecutor.ExecuteAsync<Capabilities>(this.uri, this.apiKey, request);

			return this.capabilities;
		}

		public async Task<RssChannel<SearchResult>> SearchAsync(SearchRequest request)
		{
			var result = await this.requestExecutor.ExecuteAsync<RssResult<SearchResult>>(this.uri, this.apiKey, request);

			return result.Channel;
		}

		public async Task<RssChannel<SearchResult>> SearchAsync(TvShowSearchRequest request)
		{
			var result = await this.requestExecutor.ExecuteAsync<RssResult<SearchResult>>(this.uri, this.apiKey, request);

			return result.Channel;
		}

		public async Task<RssChannel<SearchResult>> SearchAsync(MovieSearchRequest request)
		{
			var result = await this.requestExecutor.ExecuteAsync<RssResult<SearchResult>>(this.uri, this.apiKey, request);

			return result.Channel;
		}

		public async Task<RssChannel<SearchResult>> SearchAsync(MusicSearchRequest request)
		{
			var result = await this.requestExecutor.ExecuteAsync<RssResult<SearchResult>>(this.uri, this.apiKey, request);

			return result.Channel;
		}

		public async Task<RssChannel<SearchResult>> SearchAsync(BookSearchRequest request)
		{
			var result = await this.requestExecutor.ExecuteAsync<RssResult<SearchResult>>(this.uri, this.apiKey, request);

			return result.Channel;
		}
	}
}
