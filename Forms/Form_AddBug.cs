using System;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_AddBug : Form
	{
		private bool _isEditorMode = false;

		public Form_AddBug()
		{
			Initialize();
		}

		public Form_AddBug(string title, BugItem bugItem)
		{
			Initialize();

			_isEditorMode = true;
			this.Text = "Edit Bug";
			button_add.Text = "Confirm";
			comboBox_title.Text = title;
			comboBox_bugType.SelectedIndex = (int)bugItem.type;
			textBox_link.Text = bugItem.link;
		}

		private void Initialize()
		{
			InitializeComponent();
			comboBox_bugType.SelectedIndex = 0;
			if (FormReference.MainForm.CategoriesCollection != null)
			{
				foreach (Category category in FormReference.MainForm.CategoriesCollection)
				{
					comboBox_title.Items.Add(category.title);
				}
			}
		}

		private void OnCancel(object sender, EventArgs e)
		{
			ReturnToMainForm();
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			ReturnToMainForm();
		}

		private void ReturnToMainForm()
		{
			if (_isEditorMode)
				this.DialogResult = DialogResult.Cancel;
			else
				this.Hide();
		}

		private void AddBug_OnClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(comboBox_title.Text) || string.IsNullOrWhiteSpace(textBox_link.Text))
			{
				MessageBox.Show("Missing title or link.", "Error");
			}
			else
			{
				if (_isEditorMode)
					this.DialogResult = DialogResult.OK;
				else
					FormReference.MainForm.AddBug(comboBox_title.Text, (BugType)comboBox_bugType.SelectedIndex, textBox_link.Text);
			}
		}
	}
}
