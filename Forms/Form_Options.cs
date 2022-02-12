using System;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_Options : Form
	{
		public Form_Options()
		{
			InitializeComponent();

			if (ConfigSettings.Settings.TryGetValue("Name", out string name))
				textBox_name.Text = name;
			if (ConfigSettings.Settings.TryGetValue("BuildInfoPath", out string buildPath))
				textBox_buildInfoPath.Text = buildPath;
			if (ConfigSettings.Settings.TryGetValue("TitlesPath", out string titlesPath))
				textBox_titlesPath.Text = titlesPath;
		}

		private void BuildInfoBrowse_OnClick(object sender, EventArgs e)
		{
			if (openFileDialog_json.ShowDialog() == DialogResult.OK)
				textBox_buildInfoPath.Text = openFileDialog_json.FileName;
		}

		private void TitlesPathBrowse_OnClick(object sender, EventArgs e)
		{
			if (openFileDialog_json.ShowDialog() == DialogResult.OK)
				textBox_titlesPath.Text = openFileDialog_json.FileName;
		}

		private void GlobalCfgPathBrowse_OnClick(object sender, EventArgs e)
		{
			if (openFileDialog_cfg.ShowDialog() == DialogResult.OK)
				textBox_titlesPath.Text = openFileDialog_cfg.FileName;
		}

		private void Cancel_OnClick(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void Save_OnClick(object sender, EventArgs e)
		{
			ConfigSettings.Save(textBox_name.Text, textBox_buildInfoPath.Text, textBox_titlesPath.Text, textBox_globalCfg.Text);
			FormReference.MainForm.ValidateConfig();
			this.Dispose();
		}
	}
}
