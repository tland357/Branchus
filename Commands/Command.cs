using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchus
{
	public abstract class ICommand
	{
		public abstract void Do();
		public abstract void Undo();
		public ICommand Inverter;
	}
}
