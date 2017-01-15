using System;
using System.Threading.Tasks;
using Newznab.Models;

namespace Newznab
{
	public interface INewznabClient
	{
		Task<Capabilities> GetCapabilitiesAsync(Boolean forceRefresh = false);

		Task<T> ExecuteAsync<T>(NewznabWebRequest request);
	}
}