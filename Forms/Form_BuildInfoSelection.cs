using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_BuildInfoSelection : Form
	{
		public Form_BuildInfoSelection(List<BuildInfo> selectedBuilds, Platform selectedPlatform)
		{
			InitializeComponent();
			if (FormReference.MainForm.BuildInfoCollection != null)
			{
				foreach (BuildInfo buildInfo in FormReference.MainForm.BuildInfoCollection)
				{
					checkedListBox_buildInfo.Items.Add(buildInfo, selectedBuilds.Contains(buildInfo));
				}

				checkBox_pc.Checked = (selectedPlatform & Platform.PC) > 0;
				checkBox_android.Checked = (selectedPlatform & Platform.Android) > 0;
				checkBox_ios.Checked = (selectedPlatform & Platform.iOS) > 0;
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

		private void OnAddBuild(object sender, EventArgs e)
		{
			Form_AddBuildInfo form_addBuild = new Form_AddBuildInfo();
			if (form_addBuild.ShowDialog() == DialogResult.OK)
			{
				BuildInfo newBuild = new BuildInfo(form_addBuild.textBox_branch.Text, form_addBuild.textBox_build.Text, form_addBuild.textBox_cl.Text, form_addBuild.textBox_environment.Text);
				if (checkedListBox_buildInfo.Items.Contains(newBuild))
					MessageBox.Show("Build already exists!", "Error");
				else
				{
					FormReference.MainForm.AddBuildInfo(newBuild);
					checkedListBox_buildInfo.Items.Add(newBuild, true);
				}
			}
		}
	}
}
