using System;
using System.Collections.Generic;

namespace Newznab
{
	public class NewznabWebRequest : Dictionary<String, String>
	{
		public NewznabWebRequest(String command)
		{
			this.Add("t", command);
		}
	}
}
