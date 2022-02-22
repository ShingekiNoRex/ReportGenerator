
namespace ReportGenerator
{
	partial class Form_AddBuildInfo
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
			this.label_branch = new System.Windows.Forms.Label();
			this.textBox_branch = new System.Windows.Forms.TextBox();
			this.label_build = new System.Windows.Forms.Label();
			this.textBox_build = new System.Windows.Forms.TextBox();
			this.label_cl = new System.Windows.Forms.Label();
			this.label_env = new System.Windows.Forms.Label();
			this.textBox_environment = new System.Windows.Forms.TextBox();
			this.textBox_cl = new System.Windows.Forms.TextBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_branch
			// 
			this.label_branch.AutoSize = true;
			this.label_branch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_branch.Location = new System.Drawing.Point(12, 9);
			this.label_branch.Name = "label_branch";
			this.label_branch.Size = new System.Drawing.Size(70, 22);
			this.label_branch.TabIndex = 10;
			this.label_branch.Text = "Branch:";
			// 
			// textBox_branch
			// 
			this.textBox_branch.Location = new System.Drawing.Point(88, 8);
			this.textBox_branch.Name = "textBox_branch";
			this.textBox_branch.Size = new System.Drawing.Size(42, 23);
			this.textBox_branch.TabIndex = 11;
			// 
			// label_build
			// 
			this.label_build.AutoSize = true;
			this.label_build.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_build.Location = new System.Drawing.Point(136, 9);
			this.label_build.Name = "label_build";
			this.label_build.Size = new System.Drawing.Size(57, 22);
			this.label_build.TabIndex = 12;
			this.label_build.Text = "Build:";
			// 
			// textBox_build
			// 
			this.textBox_build.Location = new System.Drawing.Point(199, 8);
			this.textBox_build.Name = "textBox_build";
			this.textBox_build.Size = new System.Drawing.Size(77, 23);
			this.textBox_build.TabIndex = 13;
			// 
			// label_cl
			// 
			this.label_cl.AutoSize = true;
			this.label_cl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_cl.Location = new System.Drawing.Point(12, 52);
			this.label_cl.Name = "label_cl";
			this.label_cl.Size = new System.Drawing.Size(100, 22);
			this.label_cl.TabIndex = 14;
			this.label_cl.Text = "Changelist:";
			// 
			// label_env
			// 
			this.label_env.AutoSize = true;
			this.label_env.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_env.Location = new System.Drawing.Point(12, 93);
			this.label_env.Name = "label_env";
			this.label_env.Size = new System.Drawing.Size(118, 22);
			this.label_env.TabIndex = 16;
			this.label_env.Text = "Environment:";
			// 
			// textBox_environment
			// 
			this.textBox_environment.Location = new System.Drawing.Point(136, 92);
			this.textBox_environment.Name = "textBox_environment";
			this.textBox_environment.Size = new System.Drawing.Size(140, 23);
			this.textBox_environment.TabIndex = 18;
			// 
			// textBox_cl
			// 
			this.textBox_cl.Location = new System.Drawing.Point(136, 53);
			this.textBox_cl.Name = "textBox_cl";
			this.textBox_cl.Size = new System.Drawing.Size(140, 23);
			this.textBox_cl.TabIndex = 17;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(28, 128);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(84, 28);
			this.button_add.TabIndex = 19;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.OnAdd);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(181, 128);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(84, 28);
			this.button_cancel.TabIndex = 20;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// Form_AddBuildInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 168);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.textBox_cl);
			this.Controls.Add(this.textBox_environment);
			this.Controls.Add(this.label_env);
			this.Controls.Add(this.label_cl);
			this.Controls.Add(this.textBox_build);
			this.Controls.Add(this.label_build);
			this.Controls.Add(this.textBox_branch);
			this.Controls.Add(this.label_branch);
			this.Name = "Form_AddBuildInfo";
			this.Text = "Add Build Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox_environment;
		public System.Windows.Forms.TextBox textBox_cl;
		public System.Windows.Forms.TextBox textBox_build;
		public System.Windows.Forms.TextBox textBox_branch;

		private System.Windows.Forms.Label label_branch;
		private System.Windows.Forms.Label label_build;
		private System.Windows.Forms.Label label_cl;
		private System.Windows.Forms.Label label_env;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_cancel;
	}
}