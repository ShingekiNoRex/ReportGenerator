
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
			this.button_add = new System.Windows.Forms.Button();
			this.label_platform = new System.Windows.Forms.Label();
			this.checkBox_pc = new System.Windows.Forms.CheckBox();
			this.checkBox_android = new System.Windows.Forms.CheckBox();
			this.checkBox_ios = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(29, 283);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(96, 32);
			this.button_ok.TabIndex = 1;
			this.button_ok.Text = "Ok";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.OnOk);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(168, 283);
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
			this.checkedListBox_buildInfo.Location = new System.Drawing.Point(12, 49);
			this.checkedListBox_buildInfo.Name = "checkedListBox_buildInfo";
			this.checkedListBox_buildInfo.Size = new System.Drawing.Size(273, 184);
			this.checkedListBox_buildInfo.TabIndex = 3;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(12, 12);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(273, 31);
			this.button_add.TabIndex = 4;
			this.button_add.Text = "Add a new build";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.OnAddBuild);
			// 
			// label_platform
			// 
			this.label_platform.AutoSize = true;
			this.label_platform.Location = new System.Drawing.Point(12, 236);
			this.label_platform.Name = "label_platform";
			this.label_platform.Size = new System.Drawing.Size(57, 17);
			this.label_platform.TabIndex = 5;
			this.label_platform.Text = "Platform";
			// 
			// checkBox_pc
			// 
			this.checkBox_pc.AutoSize = true;
			this.checkBox_pc.Checked = true;
			this.checkBox_pc.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_pc.Location = new System.Drawing.Point(29, 256);
			this.checkBox_pc.Name = "checkBox_pc";
			this.checkBox_pc.Size = new System.Drawing.Size(42, 21);
			this.checkBox_pc.TabIndex = 6;
			this.checkBox_pc.Text = "PC";
			this.checkBox_pc.UseVisualStyleBackColor = true;
			// 
			// checkBox_android
			// 
			this.checkBox_android.AutoSize = true;
			this.checkBox_android.Location = new System.Drawing.Point(112, 256);
			this.checkBox_android.Name = "checkBox_android";
			this.checkBox_android.Size = new System.Drawing.Size(74, 21);
			this.checkBox_android.TabIndex = 7;
			this.checkBox_android.Text = "Android";
			this.checkBox_android.UseVisualStyleBackColor = true;
			// 
			// checkBox_ios
			// 
			this.checkBox_ios.AutoSize = true;
			this.checkBox_ios.Location = new System.Drawing.Point(217, 256);
			this.checkBox_ios.Name = "checkBox_ios";
			this.checkBox_ios.Size = new System.Drawing.Size(47, 21);
			this.checkBox_ios.TabIndex = 8;
			this.checkBox_ios.Text = "iOS";
			this.checkBox_ios.UseVisualStyleBackColor = true;
			// 
			// Form_BuildInfoSelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 324);
			this.Controls.Add(this.checkBox_ios);
			this.Controls.Add(this.checkBox_android);
			this.Controls.Add(this.checkBox_pc);
			this.Controls.Add(this.label_platform);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.checkedListBox_buildInfo);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form_BuildInfoSelection";
			this.Text = "Select Build Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.CheckedListBox checkedListBox_buildInfo;
		public System.Windows.Forms.CheckBox checkBox_pc;
		public System.Windows.Forms.CheckBox checkBox_android;
		public System.Windows.Forms.CheckBox checkBox_ios;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Label label_platform;	}
}