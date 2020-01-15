using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchus.Commands
{
	class Inverse<T> : ICommand where T : ICommand
	{
		T Command;
		public Inverse(T command)
		{
			Command = command;
		}
		public override void Do()
		{
			if (Command.Inverter == null) Command.Undo();
			else Command.Inverter.Do();
		}

		public override void Undo()
		{
			if (Command.Inverter == null) Command.Undo();
			else Command.Inverter.Undo();
		}
	}
}
