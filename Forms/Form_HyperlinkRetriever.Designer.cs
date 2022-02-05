
namespace ReportGenerator
{
	partial class Form_HyperlinkRetriever
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
			this.richTextBox_hyperlink = new System.Windows.Forms.RichTextBox();
			this.button_retrieveFromClipboard = new System.Windows.Forms.Button();
			this.checkBox_removeDuplicate = new System.Windows.Forms.CheckBox();
			this.button_copy = new System.Windows.Forms.Button();
			this.checkBox_disableClickableUrls = new System.Windows.Forms.CheckBox();
			this.label_copy = new System.Windows.Forms.Label();
			this.checkBox_removeRedundant = new System.Windows.Forms.CheckBox();
			this.button_gethtml = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox_hyperlink
			// 
			this.richTextBox_hyperlink.Location = new System.Drawing.Point(12, 12);
			this.richTextBox_hyperlink.Name = "richTextBox_hyperlink";
			this.richTextBox_hyperlink.Size = new System.Drawing.Size(374, 262);
			this.richTextBox_hyperlink.TabIndex = 0;
			this.richTextBox_hyperlink.Text = "";
			// 
			// button_retrieveFromClipboard
			// 
			this.button_retrieveFromClipboard.Location = new System.Drawing.Point(410, 95);
			this.button_retrieveFromClipboard.Name = "button_retrieveFromClipboard";
			this.button_retrieveFromClipboard.Size = new System.Drawing.Size(161, 45);
			this.button_retrieveFromClipboard.TabIndex = 1;
			this.button_retrieveFromClipboard.Text = "Retrieve from Clipboard";
			this.button_retrieveFromClipboard.UseVisualStyleBackColor = true;
			this.button_retrieveFromClipboard.Click += new System.EventHandler(this.OnRetrieveFromClipboard);
			// 
			// checkBox_removeDuplicate
			// 
			this.checkBox_removeDuplicate.AutoSize = true;
			this.checkBox_removeDuplicate.Checked = true;
			this.checkBox_removeDuplicate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_removeDuplicate.Location = new System.Drawing.Point(410, 14);
			this.checkBox_removeDuplicate.Name = "checkBox_removeDuplicate";
			this.checkBox_removeDuplicate.Size = new System.Drawing.Size(161, 21);
			this.checkBox_removeDuplicate.TabIndex = 2;
			this.checkBox_removeDuplicate.Text = "Remove duplicate links";
			this.checkBox_removeDuplicate.UseVisualStyleBackColor = true;
			// 
			// button_copy
			// 
			this.button_copy.Location = new System.Drawing.Point(410, 197);
			this.button_copy.Name = "button_copy";
			this.button_copy.Size = new System.Drawing.Size(161, 45);
			this.button_copy.TabIndex = 3;
			this.button_copy.Text = "Copy to Clipboard";
			this.button_copy.UseVisualStyleBackColor = true;
			this.button_copy.Click += new System.EventHandler(this.Copy_OnClick);
			// 
			// checkBox_disableClickableUrls
			// 
			this.checkBox_disableClickableUrls.AutoSize = true;
			this.checkBox_disableClickableUrls.Location = new System.Drawing.Point(410, 68);
			this.checkBox_disableClickableUrls.Name = "checkBox_disableClickableUrls";
			this.checkBox_disableClickableUrls.Size = new System.Drawing.Size(149, 21);
			this.checkBox_disableClickableUrls.TabIndex = 4;
			this.checkBox_disableClickableUrls.Text = "Disable clickable urls";
			this.checkBox_disableClickableUrls.UseVisualStyleBackColor = true;
			this.checkBox_disableClickableUrls.CheckedChanged += new System.EventHandler(this.DisableClickableUrls_OnCheckedChanged);
			// 
			// label_copy
			// 
			this.label_copy.AutoSize = true;
			this.label_copy.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_copy.ForeColor = System.Drawing.Color.Green;
			this.label_copy.Location = new System.Drawing.Point(410, 254);
			this.label_copy.Name = "label_copy";
			this.label_copy.Size = new System.Drawing.Size(156, 20);
			this.label_copy.TabIndex = 5;
			this.label_copy.Text = "Successfully copied!";
			this.label_copy.Visible = false;
			// 
			// checkBox_removeRedundant
			// 
			this.checkBox_removeRedundant.AutoSize = true;
			this.checkBox_removeRedundant.Checked = true;
			this.checkBox_removeRedundant.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_removeRedundant.Location = new System.Drawing.Point(410, 41);
			this.checkBox_removeRedundant.Name = "checkBox_removeRedundant";
			this.checkBox_removeRedundant.Size = new System.Drawing.Size(164, 21);
			this.checkBox_removeRedundant.TabIndex = 6;
			this.checkBox_removeRedundant.Text = "Remove redundant info";
			this.checkBox_removeRedundant.UseVisualStyleBackColor = true;
			// 
			// button_gethtml
			// 
			this.button_gethtml.Location = new System.Drawing.Point(410, 146);
			this.button_gethtml.Name = "button_gethtml";
			this.button_gethtml.Size = new System.Drawing.Size(161, 45);
			this.button_gethtml.TabIndex = 7;
			this.button_gethtml.Text = "Display HTML text";
			this.button_gethtml.UseVisualStyleBackColor = true;
			this.button_gethtml.Click += new System.EventHandler(this.DisplayHTMLText_OnClick);
			// 
			// Form_HyperlinkRetriever
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 286);
			this.Controls.Add(this.button_gethtml);
			this.Controls.Add(this.checkBox_removeRedundant);
			this.Controls.Add(this.label_copy);
			this.Controls.Add(this.checkBox_disableClickableUrls);
			this.Controls.Add(this.button_copy);
			this.Controls.Add(this.checkBox_removeDuplicate);
			this.Controls.Add(this.button_retrieveFromClipboard);
			this.Controls.Add(this.richTextBox_hyperlink);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form_HyperlinkRetriever";
			this.Text = "Hyperlink Retriever";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox_hyperlink;
		private System.Windows.Forms.Button button_retrieveFromClipboard;
		private System.Windows.Forms.CheckBox checkBox_removeDuplicate;
		private System.Windows.Forms.Button button_copy;
		private System.Windows.Forms.CheckBox checkBox_disableClickableUrls;
		private System.Windows.Forms.Label label_copy;
		private System.Windows.Forms.CheckBox checkBox_removeRedundant;
		private System.Windows.Forms.Button button_gethtml;
	}
}