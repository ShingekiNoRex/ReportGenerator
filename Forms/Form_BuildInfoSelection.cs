using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_BuildInfoSelection : Form
	{
		public Form_BuildInfoSelection(List<BuildInfo> selectedBuilds)
		{
			InitializeComponent();
			if (FormReference.MainForm.BuildInfoCollection != null)
			{
				foreach (BuildInfo buildInfo in FormReference.MainForm.BuildInfoCollection)
				{
					checkedListBox_buildInfo.Items.Add(buildInfo.ToString(), selectedBuilds.Contains(buildInfo));
				}
			}
		}

		private void OnCancel(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
