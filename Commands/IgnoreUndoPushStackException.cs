using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchus.Commands
{
	class IgnoreUndoPushStackException: Exception
	{
		string Reason;
		public IgnoreUndoPushStackException(string reason = null)
		{
			Reason = reason;
		}
	}
}
