using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchus.Commands
{
	class AddDocument: ICommand
	{
		public AddDocument(bool? topDirectory = true)
		{
			TopDirectory = topDirectory;
		}
		bool? TopDirectory;
		Branchus.DocNode addedNode;
		public override void Do()
		{
			if (TopDirectory == null)
			{
				Branchus.DocNode node = new Branchus.DocNode(new Branchus.Document() { Title = "Untitled" });
				if (Branchus.CurrentNode == null) throw new FailedExecutionUndoRedoException("You must select a document first!");
				else if (Branchus.CurrentNode.Parent == null)
				{
					Branchus.Window.treeView1.Nodes.Add(node);
				}
				else
				{
					Branchus.CurrentNode.Parent.Nodes.Add(node);
				}
				Branchus.Window.treeView1.SelectedNode = node;
				addedNode = node;
			}
			else if (TopDirectory.Value)
			{
				Branchus.DocNode node = new Branchus.DocNode(new Branchus.Document() { Title = "Untitled" });
				Branchus.Window.treeView1.Nodes.Add(node);
				Branchus.Window.treeView1.SelectedNode = node;
				addedNode = node;
			}
			else
			{
				if (Branchus.Window.treeView1.SelectedNode == null) throw new FailedExecutionUndoRedoException("You must select a document before creating a subdocument!");
				Branchus.DocNode node = new Branchus.DocNode(new Branchus.Document() { Title = "Untitled" });
				Branchus.CurrentNode.Nodes.Add(node);
				Branchus.Window.treeView1.SelectedNode = node;
				addedNode = node;
			}
		}
		public override void Undo()
		{
			Branchus.Window.treeView1.Nodes.Remove(addedNode);
			Branchus.CurrentNode = null;
			Branchus.Window.Title_TXT.Enabled = Branchus.Window.Paragraph_TXT.Enabled = false;
			Branchus.Window.treeView1.SelectedNode = null;
			Branchus.Window.Title_TXT.Text = Branchus.Window.Paragraph_TXT.Text = "";
		}
	}
}
