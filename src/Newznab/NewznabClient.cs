using System;
using System.Threading.Tasks;
using Newznab.Models;
using Newznab.Rss;
using Newznab.Web;

namespace Newznab
{
    public class NewznabClient
    {
	    private readonly String uri;
	    private readonly String apiKey;
	    private readonly NewznabWebRequestExecutor requestExecutor;

		public NewznabClient(String uri, String apiKey)
	    {
		    this.uri = uri;
		    this.apiKey = apiKey;
		    this.requestExecutor = new NewznabWebRequestExecutor();
		}
		
		public async Task<Capabilities> GetCapabilitiesAsync()
		{
			var request = new CapabilitiesRequest();
			
		    return await this.requestExecutor.ExecuteAsync<Capabilities>(this.uri, this.apiKey, request);
		}

		public async Task<RssResult<SearchResult>> SearchAsync(TvShowSearchRequest request)
		{
			return await this.requestExecutor.ExecuteAsync<RssResult<SearchResult>>(this.uri, this.apiKey, request);
		}
	}
}
