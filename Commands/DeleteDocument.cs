namespace Branchus.Commands
{
	class DeleteDocument : ICommand
	{
		Branchus.DocNode Parent;
		Branchus.DocNode Current;
		public override void Do()
		{
			Current = Branchus.CurrentNode;
			if (Current == null) throw new FailedExecutionUndoRedoException("There is no document selected to delete");
			Parent = Current.Parent as Branchus.DocNode;
			Branchus.Window.treeView1.Nodes.Remove(Current);
			Branchus.Window.treeView1.SelectedNode = null;
			if (Branchus.Window.treeView1.Nodes.Count == 0)
				Branchus.Window.newToolStripMenuItem_Click(null, null);
			Branchus.Window.Title_TXT.Text = "";
			Branchus.Window.Paragraph_TXT.Text = "";
		}

		public override void Undo()
		{
			if (Parent == null)
			{
				Branchus.Window.treeView1.Nodes.Add(Current);
				Branchus.Window.treeView1.SelectedNode = Current;
			}
			else
			{
				Parent.Nodes.Add(Current);
				Branchus.Window.treeView1.SelectedNode = Current;
			}
		}
	}
}
