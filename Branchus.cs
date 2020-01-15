using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using WinformControlExtender;
using System.Xml;
using Branchus.Commands;
using MasterObjectExtender;

namespace Branchus
{
	public partial class Branchus : Form
	{
		public static Branchus Window;
		public Branchus(string path = null)
		{
			Window = this;
			InitializeComponent();
			MaximumSize = new Size(Screen.AllScreens.Select(screen => screen.Bounds.Width).Max(), Screen.AllScreens.Select(screen => screen.Bounds.Height).Max());
			this.Traverse(c => c.PreviewKeyDown += UndoRedoHandle);
			FileName_TXT_Leave(FileName_TXT, null);
			if (path != null)
				OpenFile(path);
		}

		private void Splitter_Paint(object sender, PaintEventArgs e)
		{

		}

		private void UndoRedoHandle(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.Control) {
				if (e.KeyCode == Keys.Z)
					UndoRedo.Undo();
				else if (e.KeyCode == Keys.Y)
					UndoRedo.Redo();
				else if (e.KeyCode == Keys.Q)
					topLevelToolStripMenuItem_Click(null, null);
				else if (e.KeyCode == Keys.W)
					currentDirectoryToolStripMenuItem_Click(null, null);
				else if (e.KeyCode == Keys.E)
					subDocumentToolStripMenuItem_Click(null, null);
			} else
			{
				if (e.KeyCode == Keys.Delete)
					toolStripButton1_Click(null, null);
			}
		}

		public class Document
		{
			public string Title;
			public string Text;
			public void Load()
			{
				Window.Title_TXT.Text = this.Title;
				Window.Paragraph_TXT.Text = this.Text;
				Window.Title_TXT.Enabled = Window.Paragraph_TXT.Enabled = true;
			}
			public void Save(string title, string text)
			{
				this.Title = title; 
				this.Text = text;
			}
			public override string ToString()
			{
				return Title;
			}
		}
		public static DocNode CurrentNode;
		public class DocNode : TreeNode
		{
			static List<DocNode> AllInstances = new List<DocNode>();
			public DocNode(Document d)
			{
				Doc = d;
				AllInstances.Add(this);
			}
			public static void DisplayNames()
			{
				foreach (var node in AllInstances)
				{
					node.Text = node.Equals(CurrentNode) ? "*" + node.Doc.Title + "*" : node.Doc.Title;
				}
			}
			Document doc;
			public Document Doc
			{
				get
				{
					return doc;
				}
				set
				{
					doc = value;
					Text = doc.ToString();
				}
			}
		}

		private void SelectedDocument(object sender, TreeViewEventArgs e)
		{
			switchingDoc = true;
			CurrentNode = e.Node as DocNode;
			(e.Node as DocNode).Doc.Load();
			DocNode.DisplayNames();
		}

		bool switchingDoc;
		private void SaveDocument(object sender, EventArgs e)
		{
			if (!switchingDoc)
			{
				CurrentNode?.Doc.Save(Title_TXT.Text, Paragraph_TXT.Text);
				if (sender.Equals(Title_TXT)) {
					if (CurrentNode != null) 
						CurrentNode.Text = "*" + CurrentNode.Doc.Title + "*";
				}
				if (KeyPressed)
				{
					KeyPressed = false;
					UndoRedo.Do(new TextEditor(sender as Control, prevText, (sender as Control).Text));
				}
			}
			else
				switchingDoc = false;
		}

		private void CreateTopLevelBTN_Click(object sender, EventArgs e)
		{
			
		}

		private void CreateSubDocument_BTN_Click(object sender, EventArgs e)
		{
			UndoRedo.Do(new Commands.AddDocument(false));
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			UndoRedo.Do(new Commands.DeleteDocument());
		}

		private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Traverse(c =>
			{
				c.BackColor = Color.FromArgb(30, 30, 30);
				c.ForeColor = Color.CadetBlue;
				if (FileNameInternalTip && c == FileName_TXT) c.ForeColor = Color.Gray;
			});
		}

		private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Traverse(c =>
			{
				c.BackColor = c is TreeView || c is TextBox ? Color.White : SystemColors.Control;
				c.ForeColor = Color.Black;
				if (FileNameInternalTip && c == FileName_TXT) c.ForeColor = Color.Gray;
			});
		}

		public void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();
			CurrentNode = null;
			Window.Title_TXT.Enabled = Window.Paragraph_TXT.Enabled = Window.DeleteDocument_BTN.Enabled = false;
			treeView1.SelectedNode = null;
			FileName_TXT.Text = "";
			Window.Title_TXT.Text = "";
			Window.Paragraph_TXT.Text = "";
			FileName_TXT_Leave(FileName_TXT, null);
		}
		static string currSave;
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "branch files (*.brnch)|*.brnch|All files (*.*)|*.*";
			dialog.FileName = FileNameInternalTip ? "" : FileName_TXT.Text;
			var result = dialog.ShowDialog();
			if (result.IsAnyOf(DialogResult.OK,DialogResult.Yes))
			{
				currSave = dialog.FileName;
				if (!currSave.EndsWith(".brnch")) currSave = currSave + ".brnch";
				using (StreamWriter file = new StreamWriter(currSave))
				{
					List<DocNode> nodes = new List<DocNode>();
					foreach (DocNode node in treeView1.Nodes)
					{
						nodes.Add(node);
					}
					foreach (DocNode node in nodes.Where(n => n.Parent == null))
					{
						fileWrite(file, node);
					}
				}
			}
		}

		private void fileWrite(StreamWriter file, DocNode node, string tabs = "")
		{
			file.WriteLine(tabs + "{" + node.Doc.Title + "|" + node.Doc.Text.Replace(System.Environment.NewLine,"%").TrimEnd("%".ToCharArray()) + "}");
			foreach (DocNode child in node.Nodes)
			{
				fileWrite(file, child, tabs + "\t");
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (StreamWriter file = new StreamWriter(currSave))
			{
				List<DocNode> nodes = new List<DocNode>();
				foreach (DocNode node in treeView1.Nodes)
				{
					nodes.Add(node);
				}
				foreach (DocNode node in nodes.Where(n => n.Parent == null))
				{
					fileWrite(file, node);
				}
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "branch files (*.brnch)|*.brnch|All files (*.*)|*.*";
			var result = dialog.ShowDialog();
			if (result.IsAnyOf(DialogResult.OK,DialogResult.Yes))
			{
				OpenFile(dialog.FileName);
			}
		}

		void OpenFile(string path)
		{
			newToolStripMenuItem_Click(null, null);
			using (StreamReader file = new StreamReader(path))
			{
				int numTabs = 0, prevTabs = 0;
				Stack<DocNode> maxStack = new Stack<DocNode>();
				string[] lines = file.ReadToEnd().Split('\n');
				DocNode PrevLevel = null;
				foreach (string line in lines.Where(x => !string.IsNullOrWhiteSpace(x)))
				{
					numTabs = line.Count(x => x == '\t');
					string[] strings = line.Replace("\t", "").Replace("{", "").Replace("}", "").Replace("%", System.Environment.NewLine).Split('|');
					string title = strings[0];
					string text = strings[1];
					DocNode CurrNode;
					if (numTabs == 0)
					{
						maxStack.Clear();
						CurrNode = new DocNode(new Document() { Title = title, Text = text });
						treeView1.Nodes.Add(CurrNode);
						maxStack.Push(CurrNode);
					}
					else if (numTabs == prevTabs)
					{
						CurrNode = new DocNode(new Document() { Title = title, Text = text });
						maxStack.Peek().Nodes.Add(CurrNode);
					}
					else if (numTabs == prevTabs + 1)
					{
						CurrNode = new DocNode(new Document() { Title = title, Text = text });
						maxStack.Push(PrevLevel);
						PrevLevel.Nodes.Add(CurrNode);
					}
					else if (numTabs < prevTabs)
					{
						for (int i = 0; i < prevTabs - numTabs; i += 1)
						{
							maxStack.Pop();
						}
						CurrNode = new DocNode(new Document() { Title = title, Text = text });
						maxStack.Peek().Nodes.Add(CurrNode);
					}
					else
					{
						throw new FileLoadException("File is in an incorrect format!");
					}
					PrevLevel = CurrNode;
					prevTabs = numTabs;
				}
			}
		}

		bool KeyPressed;
		private void Paragraph_TXT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.IsAnyOf('{','}','|','%'))
				e.Handled = true;
			KeyPressed = true;
		}
		string prevText;
		private void toolStripButton1_Click_1(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
			var result = dialog.ShowDialog();
			if (result.IsAnyOf(DialogResult.Yes, DialogResult.OK))
			{
				this.Traverse(c => {
					c.Font = dialog.Font;
					if (c.IsAnyOf(Title_GB, Title_TXT)) c.Font = new Font(c.Font.FontFamily, c.Font.Size + 7);
				});
			}
			tableLayoutPanel1_Resize(null, null);
		}

		private void FileName_TXT_Click(object sender, EventArgs e)
		{
			var textbox = (sender as TextBox);
			if (FileNameInternalTip)
			{
				textbox.Text = "";
				textbox.ForeColor = this.ForeColor;
				FileNameInternalTip = false;
			}
		}
		bool FileNameInternalTip;
		private void FileName_TXT_Leave(object sender, EventArgs e)
		{
			var textbox = (sender as TextBox);
			if (textbox.Text == "")
			{
				FileNameInternalTip = true;
				textbox.Text = "File Name";
				textbox.ForeColor = Color.Gray;
			}
		}

		private void topLevelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UndoRedo.Do(new Commands.AddDocument());
		}

		private void subDocumentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UndoRedo.Do(new Commands.AddDocument(false));
		}

		private void currentDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UndoRedo.Do(new Commands.AddDocument(null));
		}

		private void Title_TXT_Enter(object sender, EventArgs e)
		{
			prevText = (sender as Control).Text;
		}

		private void Title_TXT_Leave(object sender, EventArgs e)
		{
			UndoRedo.Do(new TextEditor(sender as Control, prevText, (sender as Control).Text));
		}

		private void tableLayoutPanel1_Resize(object sender, EventArgs e)
		{
			tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, (float)Math.Sqrt(FileName_TXT.Font.Size) * 9);
		}
	}
}
