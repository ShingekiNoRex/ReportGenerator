﻿
namespace ReportGenerator
{
	partial class Form_AddTask
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
			this.label_content = new System.Windows.Forms.Label();
			this.textBox_content = new System.Windows.Forms.TextBox();
			this.label_time = new System.Windows.Forms.Label();
			this.textBox_time = new System.Windows.Forms.TextBox();
			this.label_minutes = new System.Windows.Forms.Label();
			this.label_comment = new System.Windows.Forms.Label();
			this.textBox_comment = new System.Windows.Forms.TextBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.label_title = new System.Windows.Forms.Label();
			this.comboBox_title = new System.Windows.Forms.ComboBox();
			this.label_result = new System.Windows.Forms.Label();
			this.comboBox_result = new System.Windows.Forms.ComboBox();
			this.textBox_defects = new System.Windows.Forms.TextBox();
			this.label_defects = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_content
			// 
			this.label_content.AutoSize = true;
			this.label_content.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_content.Location = new System.Drawing.Point(12, 58);
			this.label_content.Name = "label_content";
			this.label_content.Size = new System.Drawing.Size(80, 22);
			this.label_content.TabIndex = 0;
			this.label_content.Text = "Content:";
			// 
			// textBox_content
			// 
			this.textBox_content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox_content.Location = new System.Drawing.Point(12, 84);
			this.textBox_content.Multiline = true;
			this.textBox_content.Name = "textBox_content";
			this.textBox_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_content.Size = new System.Drawing.Size(378, 57);
			this.textBox_content.TabIndex = 1;
			// 
			// label_time
			// 
			this.label_time.AutoSize = true;
			this.label_time.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_time.Location = new System.Drawing.Point(218, 144);
			this.label_time.Name = "label_time";
			this.label_time.Size = new System.Drawing.Size(77, 22);
			this.label_time.TabIndex = 2;
			this.label_time.Text = "Elapsed:";
			// 
			// textBox_time
			// 
			this.textBox_time.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox_time.Location = new System.Drawing.Point(218, 170);
			this.textBox_time.Name = "textBox_time";
			this.textBox_time.Size = new System.Drawing.Size(90, 24);
			this.textBox_time.TabIndex = 3;
			this.textBox_time.Text = "0";
			this.textBox_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaskTime_OnKeyPress);
			// 
			// label_minutes
			// 
			this.label_minutes.AutoSize = true;
			this.label_minutes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_minutes.Location = new System.Drawing.Point(314, 175);
			this.label_minutes.Name = "label_minutes";
			this.label_minutes.Size = new System.Drawing.Size(76, 19);
			this.label_minutes.TabIndex = 4;
			this.label_minutes.Text = "minute(s)";
			// 
			// label_comment
			// 
			this.label_comment.AutoSize = true;
			this.label_comment.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_comment.Location = new System.Drawing.Point(12, 247);
			this.label_comment.Name = "label_comment";
			this.label_comment.Size = new System.Drawing.Size(167, 19);
			this.label_comment.TabIndex = 5;
			this.label_comment.Text = "Comment (optional):";
			// 
			// textBox_comment
			// 
			this.textBox_comment.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox_comment.Location = new System.Drawing.Point(12, 270);
			this.textBox_comment.Name = "textBox_comment";
			this.textBox_comment.Size = new System.Drawing.Size(378, 24);
			this.textBox_comment.TabIndex = 6;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(56, 300);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(115, 33);
			this.button_add.TabIndex = 7;
			this.button_add.Text = "Add Task";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.AddTask_OnClick);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(235, 300);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(115, 33);
			this.button_cancel.TabIndex = 8;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_title.Location = new System.Drawing.Point(12, 9);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(51, 22);
			this.label_title.TabIndex = 9;
			this.label_title.Text = "Title:";
			// 
			// comboBox_title
			// 
			this.comboBox_title.FormattingEnabled = true;
			this.comboBox_title.Location = new System.Drawing.Point(12, 32);
			this.comboBox_title.Name = "comboBox_title";
			this.comboBox_title.Size = new System.Drawing.Size(378, 25);
			this.comboBox_title.TabIndex = 10;
			// 
			// label_result
			// 
			this.label_result.AutoSize = true;
			this.label_result.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_result.Location = new System.Drawing.Point(12, 144);
			this.label_result.Name = "label_result";
			this.label_result.Size = new System.Drawing.Size(65, 22);
			this.label_result.TabIndex = 11;
			this.label_result.Text = "Result:";
			// 
			// comboBox_result
			// 
			this.comboBox_result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_result.FormattingEnabled = true;
			this.comboBox_result.Items.AddRange(new object[] {
            "Passed",
            "Failed",
            "Retest",
            "Blocked",
            "Dropped"});
			this.comboBox_result.Location = new System.Drawing.Point(12, 169);
			this.comboBox_result.Name = "comboBox_result";
			this.comboBox_result.Size = new System.Drawing.Size(181, 25);
			this.comboBox_result.TabIndex = 12;
			this.comboBox_result.SelectedIndexChanged += new System.EventHandler(this.Result_OnSelectedIndexChanged);
			// 
			// textBox_defects
			// 
			this.textBox_defects.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox_defects.Location = new System.Drawing.Point(12, 220);
			this.textBox_defects.Name = "textBox_defects";
			this.textBox_defects.Size = new System.Drawing.Size(378, 24);
			this.textBox_defects.TabIndex = 14;
			// 
			// label_defects
			// 
			this.label_defects.AutoSize = true;
			this.label_defects.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_defects.Location = new System.Drawing.Point(12, 197);
			this.label_defects.Name = "label_defects";
			this.label_defects.Size = new System.Drawing.Size(149, 19);
			this.label_defects.TabIndex = 13;
			this.label_defects.Text = "Defects (optional):";
			// 
			// Form_AddTask
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 343);
			this.Controls.Add(this.textBox_defects);
			this.Controls.Add(this.label_defects);
			this.Controls.Add(this.comboBox_result);
			this.Controls.Add(this.label_result);
			this.Controls.Add(this.comboBox_title);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.textBox_comment);
			this.Controls.Add(this.label_comment);
			this.Controls.Add(this.label_minutes);
			this.Controls.Add(this.textBox_time);
			this.Controls.Add(this.label_time);
			this.Controls.Add(this.textBox_content);
			this.Controls.Add(this.label_content);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form_AddTask";
			this.Text = "Add Task";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox_content;
		public System.Windows.Forms.TextBox textBox_time;
		public System.Windows.Forms.TextBox textBox_comment;
		public System.Windows.Forms.ComboBox comboBox_title;
		public System.Windows.Forms.ComboBox comboBox_result;

		private System.Windows.Forms.Label label_content;
		private System.Windows.Forms.Label label_time;
		private System.Windows.Forms.Label label_minutes;
		private System.Windows.Forms.Label label_comment;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.Label label_result;
		public System.Windows.Forms.TextBox textBox_defects;
		private System.Windows.Forms.Label label_defects;
	}
}