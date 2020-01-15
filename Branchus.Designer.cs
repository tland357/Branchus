namespace Branchus
{
	partial class Branchus
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branchus));
			this.Splitter = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.FileName_TXT = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.CreateTopLevelBTN = new System.Windows.Forms.ToolStripSplitButton();
			this.topLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.currentDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.subDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.DeleteDocument_BTN = new System.Windows.Forms.ToolStripButton();
			this.Paragraph_TXT = new System.Windows.Forms.TextBox();
			this.Title_GB = new System.Windows.Forms.GroupBox();
			this.Title_TXT = new System.Windows.Forms.TextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.Splitter.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.Title_GB.SuspendLayout();
			this.SuspendLayout();
			// 
			// Splitter
			// 
			this.Splitter.ColumnCount = 2;
			this.Splitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.Splitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.Splitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.Splitter.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.Splitter.Controls.Add(this.panel1, 1, 0);
			this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Splitter.Location = new System.Drawing.Point(0, 0);
			this.Splitter.Name = "Splitter";
			this.Splitter.RowCount = 1;
			this.Splitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Splitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.Splitter.Size = new System.Drawing.Size(702, 358);
			this.Splitter.TabIndex = 0;
			this.Splitter.Paint += new System.Windows.Forms.PaintEventHandler(this.Splitter_Paint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.FileName_TXT, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 352);
			this.tableLayoutPanel1.TabIndex = 5;
			this.tableLayoutPanel1.Resize += new System.EventHandler(this.tableLayoutPanel1_Resize);
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 38);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(163, 311);
			this.treeView1.TabIndex = 3;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectedDocument);
			// 
			// FileName_TXT
			// 
			this.FileName_TXT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileName_TXT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileName_TXT.Location = new System.Drawing.Point(3, 3);
			this.FileName_TXT.Name = "FileName_TXT";
			this.FileName_TXT.Size = new System.Drawing.Size(163, 27);
			this.FileName_TXT.TabIndex = 4;
			this.FileName_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FileName_TXT.Click += new System.EventHandler(this.FileName_TXT_Click);
			this.FileName_TXT.Leave += new System.EventHandler(this.FileName_TXT_Leave);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolStrip2);
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Controls.Add(this.Paragraph_TXT);
			this.panel1.Controls.Add(this.Title_GB);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(178, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(521, 352);
			this.panel1.TabIndex = 2;
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator2});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(521, 31);
			this.toolStrip2.TabIndex = 4;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripSplitButton2
			// 
			this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
			this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton2.Name = "toolStripSplitButton2";
			this.toolStripSplitButton2.Size = new System.Drawing.Size(51, 28);
			this.toolStripSplitButton2.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(117, 24);
			this.toolStripSplitButton1.Text = "Select Theme";
			// 
			// lightThemeToolStripMenuItem
			// 
			this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
			this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.lightThemeToolStripMenuItem.Text = "Light Theme";
			this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.lightThemeToolStripMenuItem_Click);
			// 
			// darkThemeToolStripMenuItem
			// 
			this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
			this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.darkThemeToolStripMenuItem.Text = "Dark Theme";
			this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.darkThemeToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(86, 24);
			this.toolStripButton1.Text = "Select Font";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTopLevelBTN,
            this.toolStripSeparator1,
            this.DeleteDocument_BTN,
            this.toolStripSeparator5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 321);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(521, 31);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// CreateTopLevelBTN
			// 
			this.CreateTopLevelBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.CreateTopLevelBTN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topLevelToolStripMenuItem,
            this.currentDirectoryToolStripMenuItem,
            this.subDocumentToolStripMenuItem});
			this.CreateTopLevelBTN.Image = ((System.Drawing.Image)(resources.GetObject("CreateTopLevelBTN.Image")));
			this.CreateTopLevelBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CreateTopLevelBTN.Name = "CreateTopLevelBTN";
			this.CreateTopLevelBTN.Size = new System.Drawing.Size(144, 24);
			this.CreateTopLevelBTN.Text = "Create Document";
			this.CreateTopLevelBTN.ToolTipText = "Creates a document at the top directory";
			this.CreateTopLevelBTN.Click += new System.EventHandler(this.CreateTopLevelBTN_Click);
			// 
			// topLevelToolStripMenuItem
			// 
			this.topLevelToolStripMenuItem.Name = "topLevelToolStripMenuItem";
			this.topLevelToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
			this.topLevelToolStripMenuItem.Text = "Top Level (ctrl Q)";
			this.topLevelToolStripMenuItem.Click += new System.EventHandler(this.topLevelToolStripMenuItem_Click);
			// 
			// currentDirectoryToolStripMenuItem
			// 
			this.currentDirectoryToolStripMenuItem.Name = "currentDirectoryToolStripMenuItem";
			this.currentDirectoryToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
			this.currentDirectoryToolStripMenuItem.Text = "Current Directory (ctrl W)";
			this.currentDirectoryToolStripMenuItem.Click += new System.EventHandler(this.currentDirectoryToolStripMenuItem_Click);
			// 
			// subDocumentToolStripMenuItem
			// 
			this.subDocumentToolStripMenuItem.Name = "subDocumentToolStripMenuItem";
			this.subDocumentToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
			this.subDocumentToolStripMenuItem.Text = "SubDocument (ctrl E)";
			this.subDocumentToolStripMenuItem.Click += new System.EventHandler(this.subDocumentToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// DeleteDocument_BTN
			// 
			this.DeleteDocument_BTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.DeleteDocument_BTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDocument_BTN.Image")));
			this.DeleteDocument_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteDocument_BTN.Name = "DeleteDocument_BTN";
			this.DeleteDocument_BTN.Size = new System.Drawing.Size(186, 28);
			this.DeleteDocument_BTN.Text = "Delete Document (delete)";
			this.DeleteDocument_BTN.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// Paragraph_TXT
			// 
			this.Paragraph_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Paragraph_TXT.Enabled = false;
			this.Paragraph_TXT.Location = new System.Drawing.Point(20, 146);
			this.Paragraph_TXT.Multiline = true;
			this.Paragraph_TXT.Name = "Paragraph_TXT";
			this.Paragraph_TXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Paragraph_TXT.Size = new System.Drawing.Size(492, 157);
			this.Paragraph_TXT.TabIndex = 2;
			this.Paragraph_TXT.TextChanged += new System.EventHandler(this.SaveDocument);
			this.Paragraph_TXT.Enter += new System.EventHandler(this.Title_TXT_Enter);
			this.Paragraph_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Paragraph_TXT_KeyPress);
			// 
			// Title_GB
			// 
			this.Title_GB.Controls.Add(this.Title_TXT);
			this.Title_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.Title_GB.Location = new System.Drawing.Point(20, 28);
			this.Title_GB.Name = "Title_GB";
			this.Title_GB.Size = new System.Drawing.Size(472, 96);
			this.Title_GB.TabIndex = 1;
			this.Title_GB.TabStop = false;
			this.Title_GB.Text = "Title";
			// 
			// Title_TXT
			// 
			this.Title_TXT.Enabled = false;
			this.Title_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.Title_TXT.Location = new System.Drawing.Point(17, 37);
			this.Title_TXT.Name = "Title_TXT";
			this.Title_TXT.Size = new System.Drawing.Size(434, 38);
			this.Title_TXT.TabIndex = 0;
			this.Title_TXT.TextChanged += new System.EventHandler(this.SaveDocument);
			this.Title_TXT.Enter += new System.EventHandler(this.Title_TXT_Enter);
			this.Title_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Paragraph_TXT_KeyPress);
			this.Title_TXT.Leave += new System.EventHandler(this.Title_TXT_Leave);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
			// 
			// Branchus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 358);
			this.Controls.Add(this.Splitter);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(720, 405);
			this.Name = "Branchus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Branchus";
			this.Splitter.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.Title_GB.ResumeLayout(false);
			this.Title_GB.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.TableLayoutPanel Splitter;
		public System.Windows.Forms.GroupBox Title_GB;
		public System.Windows.Forms.TextBox Title_TXT;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.ToolStrip toolStrip1;
		public System.Windows.Forms.TextBox Paragraph_TXT;
		public System.Windows.Forms.TreeView treeView1;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton DeleteDocument_BTN;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox FileName_TXT;
		public System.Windows.Forms.ToolStripSplitButton CreateTopLevelBTN;
		private System.Windows.Forms.ToolStripMenuItem subDocumentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topLevelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem currentDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
	}
}

