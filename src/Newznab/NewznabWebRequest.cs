using System;
using System.Collections.Generic;

namespace Newznab
{
	public abstract class NewznabWebRequest : Dictionary<String, String>
	{
		protected NewznabWebRequest(String command)
		{
			this.Add("t", command);
		}
	}
}
