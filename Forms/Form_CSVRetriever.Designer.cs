
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
			this.dataGridView_csv = new System.Windows.Forms.DataGridView();
			this.label_title = new System.Windows.Forms.Label();
			this.comboBox_title = new System.Windows.Forms.ComboBox();
			this.button_loadCSV = new System.Windows.Forms.Button();
			this.button_addTask = new System.Windows.Forms.Button();
			this.openFileDialog_csv = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_csv)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_csv
			// 
			this.dataGridView_csv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_csv.Location = new System.Drawing.Point(12, 81);
			this.dataGridView_csv.Name = "dataGridView_csv";
			this.dataGridView_csv.RowTemplate.Height = 25;
			this.dataGridView_csv.Size = new System.Drawing.Size(665, 357);
			this.dataGridView_csv.TabIndex = 0;
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_title.Location = new System.Drawing.Point(12, 9);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(51, 22);
			this.label_title.TabIndex = 10;
			this.label_title.Text = "Title:";
			// 
			// comboBox_title
			// 
			this.comboBox_title.FormattingEnabled = true;
			this.comboBox_title.Location = new System.Drawing.Point(12, 34);
			this.comboBox_title.Name = "comboBox_title";
			this.comboBox_title.Size = new System.Drawing.Size(325, 25);
			this.comboBox_title.TabIndex = 11;
			// 
			// button_loadCSV
			// 
			this.button_loadCSV.Location = new System.Drawing.Point(359, 29);
			this.button_loadCSV.Name = "button_loadCSV";
			this.button_loadCSV.Size = new System.Drawing.Size(150, 33);
			this.button_loadCSV.TabIndex = 12;
			this.button_loadCSV.Text = "Load CSV Table";
			this.button_loadCSV.UseVisualStyleBackColor = true;
			this.button_loadCSV.Click += new System.EventHandler(this.LoadCSV_OnClick);
			// 
			// button_addTask
			// 
			this.button_addTask.Enabled = false;
			this.button_addTask.Location = new System.Drawing.Point(527, 29);
			this.button_addTask.Name = "button_addTask";
			this.button_addTask.Size = new System.Drawing.Size(150, 33);
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
			// Form_CSVRetriever
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 450);
			this.Controls.Add(this.button_addTask);
			this.Controls.Add(this.button_loadCSV);
			this.Controls.Add(this.comboBox_title);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.dataGridView_csv);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_CSVRetriever";
			this.Text = "CSV Retriever";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_csv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_csv;
		private System.Windows.Forms.Label label_title;
		public System.Windows.Forms.ComboBox comboBox_title;
		private System.Windows.Forms.Button button_loadCSV;
		private System.Windows.Forms.Button button_addTask;
		private System.Windows.Forms.OpenFileDialog openFileDialog_csv;
	}
}