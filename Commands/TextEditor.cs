using System.Windows.Forms;

namespace Branchus.Commands
{
	class TextEditor : ICommand
	{
		Control TextHolder;
		string Next, Prev;
		public TextEditor(Control control, string prev, string next)
		{
			TextHolder = control;
			Next = next;
			Prev = prev;
		}
		public override void Do()
		{
			TextHolder.Text = Next;
		}
		public override void Undo()
		{
			TextHolder.Text = Prev;
		}
	}
}
