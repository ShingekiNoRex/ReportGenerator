
namespace ReportGenerator
{
	partial class Form_AddBug
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
			this.label_bugType = new System.Windows.Forms.Label();
			this.label_link = new System.Windows.Forms.Label();
			this.comboBox_bugType = new System.Windows.Forms.ComboBox();
			this.textBox_link = new System.Windows.Forms.TextBox();
			this.comboBox_title = new System.Windows.Forms.ComboBox();
			this.label_title = new System.Windows.Forms.Label();
			this.button_add = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_bugType
			// 
			this.label_bugType.AutoSize = true;
			this.label_bugType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_bugType.Location = new System.Drawing.Point(263, 7);
			this.label_bugType.Name = "label_bugType";
			this.label_bugType.Size = new System.Drawing.Size(86, 22);
			this.label_bugType.TabIndex = 0;
			this.label_bugType.Text = "Bug Type";
			// 
			// label_link
			// 
			this.label_link.AutoSize = true;
			this.label_link.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_link.Location = new System.Drawing.Point(12, 60);
			this.label_link.Name = "label_link";
			this.label_link.Size = new System.Drawing.Size(44, 22);
			this.label_link.TabIndex = 1;
			this.label_link.Text = "Link";
			// 
			// comboBox_bugType
			// 
			this.comboBox_bugType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_bugType.FormattingEnabled = true;
			this.comboBox_bugType.Items.AddRange(new object[] {
            "New",
            "Retested",
            "Closed"});
			this.comboBox_bugType.Location = new System.Drawing.Point(263, 32);
			this.comboBox_bugType.Name = "comboBox_bugType";
			this.comboBox_bugType.Size = new System.Drawing.Size(108, 25);
			this.comboBox_bugType.TabIndex = 2;
			// 
			// textBox_link
			// 
			this.textBox_link.Location = new System.Drawing.Point(12, 85);
			this.textBox_link.Name = "textBox_link";
			this.textBox_link.Size = new System.Drawing.Size(359, 23);
			this.textBox_link.TabIndex = 3;
			// 
			// comboBox_title
			// 
			this.comboBox_title.FormattingEnabled = true;
			this.comboBox_title.Location = new System.Drawing.Point(12, 32);
			this.comboBox_title.Name = "comboBox_title";
			this.comboBox_title.Size = new System.Drawing.Size(230, 25);
			this.comboBox_title.TabIndex = 12;
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_title.Location = new System.Drawing.Point(12, 7);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(51, 22);
			this.label_title.TabIndex = 11;
			this.label_title.Text = "Title:";
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(48, 114);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(115, 33);
			this.button_add.TabIndex = 13;
			this.button_add.Text = "Add Bug";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.AddBug_OnClick);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(218, 114);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(115, 33);
			this.button_cancel.TabIndex = 14;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// Form_AddBug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 157);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.comboBox_title);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.textBox_link);
			this.Controls.Add(this.comboBox_bugType);
			this.Controls.Add(this.label_link);
			this.Controls.Add(this.label_bugType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_AddBug";
			this.Text = "Add Bug";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ComboBox comboBox_bugType;
		public System.Windows.Forms.TextBox textBox_link;
		public System.Windows.Forms.ComboBox comboBox_title;

		private System.Windows.Forms.Label label_bugType;
		private System.Windows.Forms.Label label_link;
		private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_cancel;
	}
}