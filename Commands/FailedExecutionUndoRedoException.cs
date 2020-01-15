using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchus.Commands
{
	class FailedExecutionUndoRedoException: Exception
	{
		public FailedExecutionUndoRedoException(string message) : base(message)
		{

		}
	}
}
