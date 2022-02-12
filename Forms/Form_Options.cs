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
			if (ConfigSettings.Settings.TryGetValue("BuildInfoPath", out string path))
				textBox_buildInfoPath.Text = path;
			if (ConfigSettings.Settings.TryGetValue("TitlesPath", out path))
				textBox_titlesPath.Text = path;
			if (ConfigSettings.Settings.TryGetValue("GlobalConfig", out path))
				textBox_globalCfg.Text = path;
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
				textBox_globalCfg.Text = openFileDialog_cfg.FileName;
		}

		private void Cancel_OnClick(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void Save_OnClick(object sender, EventArgs e)
		{
			ConfigSettings.Save(textBox_name.Text, textBox_buildInfoPath.Text, textBox_titlesPath.Text, textBox_globalCfg.Text);
			this.Dispose();
			FormReference.MainForm.ValidateConfig();
		}
	}
}
