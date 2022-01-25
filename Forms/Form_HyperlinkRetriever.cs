﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_HyperlinkRetriever : Form
	{
		public Form_HyperlinkRetriever()
		{
			InitializeComponent();
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void OnRetrieveFromClipboard(object sender, EventArgs e)
		{
			string links = "";
			Regex reg = new Regex(@"(?is)<a[^>]*?href=(['""\s]?)(?<href>[^'""\s]*)\1[^>]*?>");
			foreach (Match match in reg.Matches(Clipboard.GetText(TextDataFormat.Html)))
			{
				if (checkBox_removeDuplicate.Checked && links.Contains(match.Groups["href"].Value))
					continue;

				links = links + match.Groups["href"].Value + Environment.NewLine;
			}

			richTextBox_hyperlink.Text = links;
		}

		private void Copy_OnClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(richTextBox_hyperlink.Text))
			{
				Clipboard.SetText(richTextBox_hyperlink.Text);
				label_copy.Visible = true;
			}
			else
				label_copy.Visible = false;
		}

		private void DisableClickableUrls_OnCheckedChanged(object sender, EventArgs e)
		{
			richTextBox_hyperlink.DetectUrls = !checkBox_disableClickableUrls.Checked;
		}
	}
}
