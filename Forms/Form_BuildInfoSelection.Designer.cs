
namespace ReportGenerator
{
	partial class Form_BuildInfoSelection
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
			this.button_ok = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.checkedListBox_buildInfo = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(31, 252);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(96, 32);
			this.button_ok.TabIndex = 1;
			this.button_ok.Text = "Ok";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.OnOk);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(172, 252);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(96, 32);
			this.button_cancel.TabIndex = 2;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// checkedListBox_buildInfo
			// 
			this.checkedListBox_buildInfo.CheckOnClick = true;
			this.checkedListBox_buildInfo.FormattingEnabled = true;
			this.checkedListBox_buildInfo.Location = new System.Drawing.Point(12, 12);
			this.checkedListBox_buildInfo.Name = "checkedListBox_buildInfo";
			this.checkedListBox_buildInfo.Size = new System.Drawing.Size(284, 220);
			this.checkedListBox_buildInfo.TabIndex = 3;
			// 
			// Form_BuildInfoSelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 299);
			this.Controls.Add(this.checkedListBox_buildInfo);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_BuildInfoSelection";
			this.Text = "Select Build Info";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.CheckedListBox checkedListBox_buildInfo;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Button button_cancel;
	}
}