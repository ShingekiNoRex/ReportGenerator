
namespace ReportGenerator
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hyperlinkRetrieverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_date = new System.Windows.Forms.Label();
			this.label_date_from = new System.Windows.Forms.Label();
			this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
			this.label_date_to = new System.Windows.Forms.Label();
			this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
			this.label_buildinfo = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label_installTime = new System.Windows.Forms.Label();
			this.textBox_installTime = new System.Windows.Forms.TextBox();
			this.label_minuits = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.button_buildInfoSelection = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_remove = new System.Windows.Forms.Button();
			this.button_edit = new System.Windows.Forms.Button();
			this.button_saveAs = new System.Windows.Forms.Button();
			this.button_saveAsJson = new System.Windows.Forms.Button();
			this.button_saveAsTxt = new System.Windows.Forms.Button();
			this.button_addBug = new System.Windows.Forms.Button();
			this.button_addTask = new System.Windows.Forms.Button();
			this.treeView_tasklist = new System.Windows.Forms.TreeView();
			this.saveFileDialog_json = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog_json = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog_txt = new System.Windows.Forms.SaveFileDialog();
			this.mainMenuStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(457, 25);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "mainMenuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewFile_OnClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_OnClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_OnClick);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_OnClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_OnClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.hyperlinkRetrieverToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.Options_OnClick);
			// 
			// hyperlinkRetrieverToolStripMenuItem
			// 
			this.hyperlinkRetrieverToolStripMenuItem.Name = "hyperlinkRetrieverToolStripMenuItem";
			this.hyperlinkRetrieverToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.hyperlinkRetrieverToolStripMenuItem.Text = "Hyperlink Retriever";
			this.hyperlinkRetrieverToolStripMenuItem.Click += new System.EventHandler(this.HyperlinkRetriever_OnClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// label_date
			// 
			this.label_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_date.Location = new System.Drawing.Point(3, 0);
			this.label_date.Name = "label_date";
			this.label_date.Size = new System.Drawing.Size(107, 26);
			this.label_date.TabIndex = 2;
			this.label_date.Text = "Date:";
			this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_date_from
			// 
			this.label_date_from.Location = new System.Drawing.Point(116, 0);
			this.label_date_from.Name = "label_date_from";
			this.label_date_from.Size = new System.Drawing.Size(39, 26);
			this.label_date_from.TabIndex = 5;
			this.label_date_from.Text = "From";
			this.label_date_from.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateTimePicker_from
			// 
			this.dateTimePicker_from.CustomFormat = "M/d/yyyy";
			this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_from.Location = new System.Drawing.Point(161, 3);
			this.dateTimePicker_from.Name = "dateTimePicker_from";
			this.dateTimePicker_from.Size = new System.Drawing.Size(110, 23);
			this.dateTimePicker_from.TabIndex = 3;
			this.dateTimePicker_from.Value = new System.DateTime(2022, 1, 16, 0, 0, 0, 0);
			this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.FromDate_OnValueChanged);
			// 
			// label_date_to
			// 
			this.label_date_to.Location = new System.Drawing.Point(277, 0);
			this.label_date_to.Name = "label_date_to";
			this.label_date_to.Size = new System.Drawing.Size(39, 26);
			this.label_date_to.TabIndex = 6;
			this.label_date_to.Text = "to";
			this.label_date_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker_to
			// 
			this.dateTimePicker_to.CustomFormat = "M/d/yyyy";
			this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_to.Location = new System.Drawing.Point(322, 3);
			this.dateTimePicker_to.Name = "dateTimePicker_to";
			this.dateTimePicker_to.Size = new System.Drawing.Size(110, 23);
			this.dateTimePicker_to.TabIndex = 4;
			this.dateTimePicker_to.Value = new System.DateTime(2022, 1, 16, 0, 0, 0, 0);
			this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.ToDate_OnValueChanged);
			// 
			// label_buildinfo
			// 
			this.label_buildinfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_buildinfo.Location = new System.Drawing.Point(3, 0);
			this.label_buildinfo.Name = "label_buildinfo";
			this.label_buildinfo.Size = new System.Drawing.Size(107, 26);
			this.label_buildinfo.TabIndex = 1;
			this.label_buildinfo.Text = "Build Info:";
			this.label_buildinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 28);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 355);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label_installTime);
			this.flowLayoutPanel1.Controls.Add(this.textBox_installTime);
			this.flowLayoutPanel1.Controls.Add(this.label_minuits);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 73);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 29);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// label_installTime
			// 
			this.label_installTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_installTime.Location = new System.Drawing.Point(3, 0);
			this.label_installTime.Name = "label_installTime";
			this.label_installTime.Size = new System.Drawing.Size(152, 26);
			this.label_installTime.TabIndex = 1;
			this.label_installTime.Text = "Installation Time:";
			this.label_installTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_installTime
			// 
			this.textBox_installTime.Location = new System.Drawing.Point(161, 3);
			this.textBox_installTime.Name = "textBox_installTime";
			this.textBox_installTime.Size = new System.Drawing.Size(110, 23);
			this.textBox_installTime.TabIndex = 2;
			this.textBox_installTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_installTime.TextChanged += new System.EventHandler(this.OnReportChanged);
			this.textBox_installTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InstallTime_OnKeyPress);
			// 
			// label_minuits
			// 
			this.label_minuits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label_minuits.Location = new System.Drawing.Point(277, 0);
			this.label_minuits.Name = "label_minuits";
			this.label_minuits.Size = new System.Drawing.Size(100, 26);
			this.label_minuits.TabIndex = 3;
			this.label_minuits.Text = "minute(s)";
			this.label_minuits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.label_date);
			this.flowLayoutPanel3.Controls.Add(this.label_date_from);
			this.flowLayoutPanel3.Controls.Add(this.dateTimePicker_from);
			this.flowLayoutPanel3.Controls.Add(this.label_date_to);
			this.flowLayoutPanel3.Controls.Add(this.dateTimePicker_to);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(448, 29);
			this.flowLayoutPanel3.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label_buildinfo);
			this.flowLayoutPanel2.Controls.Add(this.button_buildInfoSelection);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 38);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(448, 29);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// button_buildInfoSelection
			// 
			this.button_buildInfoSelection.Location = new System.Drawing.Point(116, 3);
			this.button_buildInfoSelection.Name = "button_buildInfoSelection";
			this.button_buildInfoSelection.Size = new System.Drawing.Size(316, 23);
			this.button_buildInfoSelection.TabIndex = 2;
			this.button_buildInfoSelection.Text = "Select a build...";
			this.button_buildInfoSelection.UseVisualStyleBackColor = true;
			this.button_buildInfoSelection.Click += new System.EventHandler(this.BuildInfoSelection_OnClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button_remove);
			this.panel1.Controls.Add(this.button_edit);
			this.panel1.Controls.Add(this.button_saveAs);
			this.panel1.Controls.Add(this.button_saveAsJson);
			this.panel1.Controls.Add(this.button_saveAsTxt);
			this.panel1.Controls.Add(this.button_addBug);
			this.panel1.Controls.Add(this.button_addTask);
			this.panel1.Controls.Add(this.treeView_tasklist);
			this.panel1.Location = new System.Drawing.Point(3, 108);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(448, 244);
			this.panel1.TabIndex = 2;
			// 
			// button_remove
			// 
			this.button_remove.Enabled = false;
			this.button_remove.Location = new System.Drawing.Point(288, 112);
			this.button_remove.Name = "button_remove";
			this.button_remove.Size = new System.Drawing.Size(144, 28);
			this.button_remove.TabIndex = 7;
			this.button_remove.Text = "Remove";
			this.button_remove.UseVisualStyleBackColor = true;
			this.button_remove.Click += new System.EventHandler(this.OnRemove);
			// 
			// button_edit
			// 
			this.button_edit.Enabled = false;
			this.button_edit.Location = new System.Drawing.Point(288, 78);
			this.button_edit.Name = "button_edit";
			this.button_edit.Size = new System.Drawing.Size(144, 28);
			this.button_edit.TabIndex = 6;
			this.button_edit.Text = "Edit";
			this.button_edit.UseVisualStyleBackColor = true;
			this.button_edit.Click += new System.EventHandler(this.OnEdit);
			// 
			// button_saveAs
			// 
			this.button_saveAs.Location = new System.Drawing.Point(288, 182);
			this.button_saveAs.Name = "button_saveAs";
			this.button_saveAs.Size = new System.Drawing.Size(144, 28);
			this.button_saveAs.TabIndex = 5;
			this.button_saveAs.Text = "Save As";
			this.button_saveAs.UseVisualStyleBackColor = true;
			this.button_saveAs.Click += new System.EventHandler(this.SaveAs_OnClick);
			// 
			// button_saveAsJson
			// 
			this.button_saveAsJson.Location = new System.Drawing.Point(288, 148);
			this.button_saveAsJson.Name = "button_saveAsJson";
			this.button_saveAsJson.Size = new System.Drawing.Size(144, 28);
			this.button_saveAsJson.TabIndex = 4;
			this.button_saveAsJson.Text = "Save";
			this.button_saveAsJson.UseVisualStyleBackColor = true;
			this.button_saveAsJson.Click += new System.EventHandler(this.Save_OnClick);
			// 
			// button_saveAsTxt
			// 
			this.button_saveAsTxt.Location = new System.Drawing.Point(288, 216);
			this.button_saveAsTxt.Name = "button_saveAsTxt";
			this.button_saveAsTxt.Size = new System.Drawing.Size(144, 28);
			this.button_saveAsTxt.TabIndex = 3;
			this.button_saveAsTxt.Text = "Generate Txt Report";
			this.button_saveAsTxt.UseVisualStyleBackColor = true;
			this.button_saveAsTxt.Click += new System.EventHandler(this.GenerateTxtFile_OnClick);
			// 
			// button_addBug
			// 
			this.button_addBug.Location = new System.Drawing.Point(288, 44);
			this.button_addBug.Name = "button_addBug";
			this.button_addBug.Size = new System.Drawing.Size(144, 28);
			this.button_addBug.TabIndex = 2;
			this.button_addBug.Text = "Add Bug";
			this.button_addBug.UseVisualStyleBackColor = true;
			this.button_addBug.Click += new System.EventHandler(this.AddBug_OnClick);
			// 
			// button_addTask
			// 
			this.button_addTask.Location = new System.Drawing.Point(288, 10);
			this.button_addTask.Name = "button_addTask";
			this.button_addTask.Size = new System.Drawing.Size(144, 28);
			this.button_addTask.TabIndex = 1;
			this.button_addTask.Text = "Add Task";
			this.button_addTask.UseVisualStyleBackColor = true;
			this.button_addTask.Click += new System.EventHandler(this.AddTask_OnClick);
			// 
			// treeView_tasklist
			// 
			this.treeView_tasklist.Location = new System.Drawing.Point(8, 10);
			this.treeView_tasklist.Name = "treeView_tasklist";
			this.treeView_tasklist.Size = new System.Drawing.Size(263, 234);
			this.treeView_tasklist.TabIndex = 0;
			this.treeView_tasklist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TaskList_OnAfterSelect);
			this.treeView_tasklist.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TaskList_OnNodeMouseClick);
			// 
			// saveFileDialog_json
			// 
			this.saveFileDialog_json.Filter = "JSON File|*.json";
			this.saveFileDialog_json.RestoreDirectory = true;
			// 
			// openFileDialog_json
			// 
			this.openFileDialog_json.Filter = "JSON File|*.json";
			this.openFileDialog_json.Multiselect = true;
			this.openFileDialog_json.RestoreDirectory = true;
			// 
			// saveFileDialog_txt
			// 
			this.saveFileDialog_txt.Filter = "Text File|*.txt";
			this.saveFileDialog_txt.RestoreDirectory = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 394);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Untitled - Report Generator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label label_buildinfo;
		private System.Windows.Forms.Label label_date;
		private System.Windows.Forms.Label label_date_from;
		private System.Windows.Forms.DateTimePicker dateTimePicker_from;
		private System.Windows.Forms.Label label_date_to;
		private System.Windows.Forms.DateTimePicker dateTimePicker_to;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label_installTime;
		private System.Windows.Forms.TextBox textBox_installTime;
		private System.Windows.Forms.Label label_minuits;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TreeView treeView_tasklist;
		private System.Windows.Forms.Button button_saveAs;
		private System.Windows.Forms.Button button_saveAsJson;
		private System.Windows.Forms.Button button_saveAsTxt;
		private System.Windows.Forms.Button button_addBug;
		private System.Windows.Forms.Button button_addTask;
		private System.Windows.Forms.Button button_edit;
		private System.Windows.Forms.Button button_remove;
		private System.Windows.Forms.SaveFileDialog saveFileDialog_json;
		private System.Windows.Forms.OpenFileDialog openFileDialog_json;
		private System.Windows.Forms.SaveFileDialog saveFileDialog_txt;
		private System.Windows.Forms.ToolStripMenuItem hyperlinkRetrieverToolStripMenuItem;
		private System.Windows.Forms.Button button_buildInfoSelection;
	}
}

