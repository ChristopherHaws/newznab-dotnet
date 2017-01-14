using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Newznab.Web
{
	public class NewznabWebRequestExecutor
	{
		public async Task<T> ExecuteAsync<T>(String baseUri, String apiKey, NewznabWebRequest request)
		{
			var serializer = new XmlSerializer(typeof(T));
			
			var uriBuilder = new StringBuilder();
			uriBuilder.Append(baseUri);
			uriBuilder.Append("/api?apikey=");
			uriBuilder.Append(apiKey);
			
			foreach (var queryParameter in request)
			{
				uriBuilder.Append("&");
				uriBuilder.Append(queryParameter.Key);
				uriBuilder.Append("=");
				uriBuilder.Append(queryParameter.Value);
			}

			using (var client = new HttpClient())
			using (var stream = await client.GetStreamAsync(uriBuilder.ToString()))
			{
				return (T)serializer.Deserialize(stream);
			}
		}
	}
}
