using System;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_AddBuildInfo : Form
	{
		public Form_AddBuildInfo()
		{
			InitializeComponent();
		}

		private void OnAdd(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox_branch.Text) || string.IsNullOrWhiteSpace(textBox_build.Text) || string.IsNullOrWhiteSpace(textBox_cl.Text) || string.IsNullOrWhiteSpace(textBox_environment.Text))
				MessageBox.Show("Missing parameter(s)", "Error");
			else
				this.DialogResult = DialogResult.OK;
		}

		private void OnCancel(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
