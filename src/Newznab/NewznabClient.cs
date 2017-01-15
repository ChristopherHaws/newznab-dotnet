using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newznab.Models;

namespace Newznab
{
    public class NewznabClient : INewznabClient
    {
	    private readonly String uri;
	    private readonly String apiKey;

	    private Capabilities capabilities;

		public NewznabClient(String uri, String apiKey)
	    {
		    this.uri = uri;
		    this.apiKey = apiKey;
		}
		
		public async Task<Capabilities> GetCapabilitiesAsync(Boolean forceRefresh = false)
		{
			if (this.capabilities != null && !forceRefresh)
			{
				return this.capabilities;
			}

			var request = new CapabilitiesRequest();

			this.capabilities = await this.ExecuteAsync<Capabilities>(request);

			return this.capabilities;
		}

		public async Task<T> ExecuteAsync<T>(NewznabWebRequest request)
		{
			var serializer = new XmlSerializer(typeof(T));

			var uriBuilder = new StringBuilder();
			uriBuilder.Append(this.uri);
			uriBuilder.Append("/api?apikey=");
			uriBuilder.Append(this.apiKey);

			foreach (var queryParameter in request)
			{
				uriBuilder.Append("&");
				uriBuilder.Append(WebUtility.UrlEncode(queryParameter.Key));
				uriBuilder.Append("=");
				uriBuilder.Append(WebUtility.UrlEncode(queryParameter.Value));
			}

			using (var client = new HttpClient())
			using (var stream = await client.GetStreamAsync(uriBuilder.ToString()))
			{
				return (T)serializer.Deserialize(stream);
			}
		}
	}
}
