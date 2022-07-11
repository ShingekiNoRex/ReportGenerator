
namespace ReportGenerator
{
	partial class Form_CSVRetriever
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CSVRetriever));
			this.dataGridView_csv = new System.Windows.Forms.DataGridView();
			this.label_title = new System.Windows.Forms.Label();
			this.comboBox_title = new System.Windows.Forms.ComboBox();
			this.button_loadCSV = new System.Windows.Forms.Button();
			this.button_addTask = new System.Windows.Forms.Button();
			this.openFileDialog_csv = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_csv)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView_csv
			// 
			this.dataGridView_csv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_csv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_csv.Location = new System.Drawing.Point(6, 66);
			this.dataGridView_csv.Name = "dataGridView_csv";
			this.dataGridView_csv.RowTemplate.Height = 25;
			this.dataGridView_csv.Size = new System.Drawing.Size(658, 302);
			this.dataGridView_csv.TabIndex = 0;
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_title.Location = new System.Drawing.Point(0, 0);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(51, 22);
			this.label_title.TabIndex = 10;
			this.label_title.Text = "Title:";
			// 
			// comboBox_title
			// 
			this.comboBox_title.FormattingEnabled = true;
			this.comboBox_title.Location = new System.Drawing.Point(0, 25);
			this.comboBox_title.Name = "comboBox_title";
			this.comboBox_title.Size = new System.Drawing.Size(325, 25);
			this.comboBox_title.TabIndex = 11;
			// 
			// button_loadCSV
			// 
			this.button_loadCSV.Location = new System.Drawing.Point(342, 21);
			this.button_loadCSV.Name = "button_loadCSV";
			this.button_loadCSV.Size = new System.Drawing.Size(150, 31);
			this.button_loadCSV.TabIndex = 12;
			this.button_loadCSV.Text = "Load CSV Table";
			this.button_loadCSV.UseVisualStyleBackColor = true;
			this.button_loadCSV.Click += new System.EventHandler(this.LoadCSV_OnClick);
			// 
			// button_addTask
			// 
			this.button_addTask.Enabled = false;
			this.button_addTask.Location = new System.Drawing.Point(508, 21);
			this.button_addTask.Name = "button_addTask";
			this.button_addTask.Size = new System.Drawing.Size(150, 31);
			this.button_addTask.TabIndex = 13;
			this.button_addTask.Text = "Add Task from Table";
			this.button_addTask.UseVisualStyleBackColor = true;
			this.button_addTask.Click += new System.EventHandler(this.AddTask_OnClick);
			// 
			// openFileDialog_csv
			// 
			this.openFileDialog_csv.Filter = "CSV Table|*.csv";
			this.openFileDialog_csv.RestoreDirectory = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView_csv, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 374);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel1.Controls.Add(this.label_title);
			this.panel1.Controls.Add(this.comboBox_title);
			this.panel1.Controls.Add(this.button_addTask);
			this.panel1.Controls.Add(this.button_loadCSV);
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(658, 54);
			this.panel1.TabIndex = 11;
			// 
			// Form_CSVRetriever
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 374);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(686, 413);
			this.Name = "Form_CSVRetriever";
			this.Text = "CSV Retriever";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_csv)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_csv;
		private System.Windows.Forms.Label label_title;
		public System.Windows.Forms.ComboBox comboBox_title;
		private System.Windows.Forms.Button button_loadCSV;
		private System.Windows.Forms.Button button_addTask;
		private System.Windows.Forms.OpenFileDialog openFileDialog_csv;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
	}
}