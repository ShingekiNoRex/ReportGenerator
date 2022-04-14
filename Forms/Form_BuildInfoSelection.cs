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
					checkedListBox_buildInfo.Items.Add(buildInfo, selectedBuilds.Contains(buildInfo));
					if (buildInfo.platform == 0)
						buildInfo.platform = Platform.PC;
				}
			}
		}

		private void OnCancel(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void OnOk(object sender, EventArgs e)
		{
			if (checkedListBox_buildInfo.CheckedItems.Count <= 0)
			{
				MessageBox.Show("You need to select a build!", "Missing build");
				return;
			}

			foreach (var checkedItem in checkedListBox_buildInfo.CheckedItems)
			{
				if (checkedItem is BuildInfo checkedBuild)
				{
					if (checkedBuild.platform != 0)
					{
						this.DialogResult = DialogResult.OK;
						return;
					}
				}
			}

			MessageBox.Show("You need to select a platform!", "Missing platform");
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

		private void OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (checkedListBox_buildInfo.SelectedItem is BuildInfo selectedBuild)
			{
				checkBox_pc.Enabled = true;
				checkBox_android.Enabled = true;
				checkBox_ios.Enabled = true;

				checkBox_pc.Checked = (selectedBuild.platform & Platform.PC) > 0;
				checkBox_android.Checked = (selectedBuild.platform & Platform.Android) > 0;
				checkBox_ios.Checked = (selectedBuild.platform & Platform.iOS) > 0;

				label_platform.Text = "Platform: " + selectedBuild.ToString();
			}
		}

		private void OnPlatformSelected(object sender, EventArgs e)
		{
			if (checkedListBox_buildInfo.SelectedItem is BuildInfo selectedBuild)
				selectedBuild.platform = (checkBox_pc.Checked ? Platform.PC : 0) | (checkBox_android.Checked ? Platform.Android : 0) | (checkBox_ios.Checked ? Platform.iOS : 0);
		}
	}
}
