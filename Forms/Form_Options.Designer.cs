
namespace ReportGenerator
{
	partial class Form_Options
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
			this.label_name = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label_buildInfoPath = new System.Windows.Forms.Label();
			this.textBox_buildInfoPath = new System.Windows.Forms.TextBox();
			this.button_browseBuildInfoPath = new System.Windows.Forms.Button();
			this.openFileDialog_json = new System.Windows.Forms.OpenFileDialog();
			this.label_titlesPath = new System.Windows.Forms.Label();
			this.textBox_titlesPath = new System.Windows.Forms.TextBox();
			this.button_browseTitlesPath = new System.Windows.Forms.Button();
			this.button_save = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_browseGlobalCfg = new System.Windows.Forms.Button();
			this.textBox_globalCfg = new System.Windows.Forms.TextBox();
			this.label_globalCfg = new System.Windows.Forms.Label();
			this.openFileDialog_cfg = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Location = new System.Drawing.Point(12, 11);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(43, 17);
			this.label_name.TabIndex = 0;
			this.label_name.Text = "Name";
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(129, 8);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(216, 23);
			this.textBox_name.TabIndex = 1;
			// 
			// label_buildInfoPath
			// 
			this.label_buildInfoPath.AutoSize = true;
			this.label_buildInfoPath.Location = new System.Drawing.Point(12, 40);
			this.label_buildInfoPath.Name = "label_buildInfoPath";
			this.label_buildInfoPath.Size = new System.Drawing.Size(93, 17);
			this.label_buildInfoPath.TabIndex = 2;
			this.label_buildInfoPath.Text = "Build Info Path";
			// 
			// textBox_buildInfoPath
			// 
			this.textBox_buildInfoPath.Location = new System.Drawing.Point(129, 37);
			this.textBox_buildInfoPath.Name = "textBox_buildInfoPath";
			this.textBox_buildInfoPath.Size = new System.Drawing.Size(216, 23);
			this.textBox_buildInfoPath.TabIndex = 3;
			// 
			// button_browseBuildInfoPath
			// 
			this.button_browseBuildInfoPath.Location = new System.Drawing.Point(351, 37);
			this.button_browseBuildInfoPath.Name = "button_browseBuildInfoPath";
			this.button_browseBuildInfoPath.Size = new System.Drawing.Size(75, 23);
			this.button_browseBuildInfoPath.TabIndex = 4;
			this.button_browseBuildInfoPath.Text = "Browse...";
			this.button_browseBuildInfoPath.UseVisualStyleBackColor = true;
			this.button_browseBuildInfoPath.Click += new System.EventHandler(this.BuildInfoBrowse_OnClick);
			// 
			// openFileDialog_json
			// 
			this.openFileDialog_json.Filter = "JSON File|*.json";
			this.openFileDialog_json.RestoreDirectory = true;
			// 
			// label_titlesPath
			// 
			this.label_titlesPath.AutoSize = true;
			this.label_titlesPath.Location = new System.Drawing.Point(12, 69);
			this.label_titlesPath.Name = "label_titlesPath";
			this.label_titlesPath.Size = new System.Drawing.Size(67, 17);
			this.label_titlesPath.TabIndex = 5;
			this.label_titlesPath.Text = "Titles Path";
			// 
			// textBox_titlesPath
			// 
			this.textBox_titlesPath.Location = new System.Drawing.Point(129, 66);
			this.textBox_titlesPath.Name = "textBox_titlesPath";
			this.textBox_titlesPath.Size = new System.Drawing.Size(216, 23);
			this.textBox_titlesPath.TabIndex = 6;
			// 
			// button_browseTitlesPath
			// 
			this.button_browseTitlesPath.Location = new System.Drawing.Point(351, 66);
			this.button_browseTitlesPath.Name = "button_browseTitlesPath";
			this.button_browseTitlesPath.Size = new System.Drawing.Size(75, 23);
			this.button_browseTitlesPath.TabIndex = 7;
			this.button_browseTitlesPath.Text = "Browse...";
			this.button_browseTitlesPath.UseVisualStyleBackColor = true;
			this.button_browseTitlesPath.Click += new System.EventHandler(this.TitlesPathBrowse_OnClick);
			// 
			// button_save
			// 
			this.button_save.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button_save.Location = new System.Drawing.Point(71, 134);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(120, 30);
			this.button_save.TabIndex = 8;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.Save_OnClick);
			// 
			// button_cancel
			// 
			this.button_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button_cancel.Location = new System.Drawing.Point(244, 134);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(120, 30);
			this.button_cancel.TabIndex = 9;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.Cancel_OnClick);
			// 
			// button_browseGlobalCfg
			// 
			this.button_browseGlobalCfg.Location = new System.Drawing.Point(351, 95);
			this.button_browseGlobalCfg.Name = "button_browseGlobalCfg";
			this.button_browseGlobalCfg.Size = new System.Drawing.Size(75, 23);
			this.button_browseGlobalCfg.TabIndex = 12;
			this.button_browseGlobalCfg.Text = "Browse...";
			this.button_browseGlobalCfg.UseVisualStyleBackColor = true;
			// 
			// textBox_globalCfg
			// 
			this.textBox_globalCfg.Location = new System.Drawing.Point(129, 95);
			this.textBox_globalCfg.Name = "textBox_globalCfg";
			this.textBox_globalCfg.Size = new System.Drawing.Size(216, 23);
			this.textBox_globalCfg.TabIndex = 11;
			// 
			// label_globalCfg
			// 
			this.label_globalCfg.AutoSize = true;
			this.label_globalCfg.Location = new System.Drawing.Point(12, 98);
			this.label_globalCfg.Name = "label_globalCfg";
			this.label_globalCfg.Size = new System.Drawing.Size(117, 17);
			this.label_globalCfg.TabIndex = 10;
			this.label_globalCfg.Text = "Global Config Path";
			// 
			// openFileDialog_cfg
			// 
			this.openFileDialog_cfg.Filter = "Config File|*.cfg";
			this.openFileDialog_cfg.RestoreDirectory = true;
			// 
			// Form_Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 176);
			this.Controls.Add(this.button_browseGlobalCfg);
			this.Controls.Add(this.textBox_globalCfg);
			this.Controls.Add(this.label_globalCfg);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.button_browseTitlesPath);
			this.Controls.Add(this.textBox_titlesPath);
			this.Controls.Add(this.label_titlesPath);
			this.Controls.Add(this.button_browseBuildInfoPath);
			this.Controls.Add(this.textBox_buildInfoPath);
			this.Controls.Add(this.label_buildInfoPath);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.label_name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form_Options";
			this.Text = "Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.Label label_buildInfoPath;
		private System.Windows.Forms.TextBox textBox_buildInfoPath;
		private System.Windows.Forms.Button button_browseBuildInfoPath;
		private System.Windows.Forms.OpenFileDialog openFileDialog_json;
		private System.Windows.Forms.Label label_titlesPath;
		private System.Windows.Forms.TextBox textBox_titlesPath;
		private System.Windows.Forms.Button button_browseTitlesPath;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_browseGlobalCfg;
		private System.Windows.Forms.TextBox textBox_globalCfg;
		private System.Windows.Forms.Label label_globalCfg;
		private System.Windows.Forms.OpenFileDialog openFileDialog_cfg;
	}
}