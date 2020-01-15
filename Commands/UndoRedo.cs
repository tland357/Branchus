using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branchus.Commands
{
	public static class UndoRedo
	{
		public static Stack<ICommand> Undos = new Stack<ICommand>();
		public static Stack<ICommand> Redos = new Stack<ICommand>();
		public static void Do(ICommand command)
		{
			try
			{
				try
				{
					command.Do();
					Undos.Push(command);
					if (Redos.Count > 0) Redos.Clear();
				}
				catch (FailedExecutionUndoRedoException e)
				{
					MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (IgnoreUndoPushStackException) {}
		}

		public static void Undo()
		{
			if (Undos.Count <= 0) return;
			ICommand command = Undos.Pop();
			command.Undo();
			Redos.Push(command);
		}

		public static void Redo()
		{
			if (Redos.Count <= 0) return;
			ICommand command = Redos.Pop();
			command.Do();
			Undos.Push(command);
		}
	}
}
