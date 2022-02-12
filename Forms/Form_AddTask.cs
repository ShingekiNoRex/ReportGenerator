using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_AddTask : Form
	{
		private bool _isEditorMode = false;

		public Form_AddTask()
		{
			Initialize();
		}

		public Form_AddTask(string title, TaskItem taskItem)
		{
			Initialize();

			_isEditorMode = true;
			this.Text = "Edit Task";
			button_add.Text = "Confirm";
			comboBox_title.Text = title;
			comboBox_result.SelectedIndex = (int)taskItem.result;
			textBox_content.Text = taskItem.content;
			textBox_time.Text = taskItem.time.ToString();
			textBox_comment.Text = taskItem.comment;
		}

		private void Initialize()
		{
			InitializeComponent();
			if (FormReference.MainForm.CategoriesCollection != null)
			{
				foreach (Category category in FormReference.MainForm.CategoriesCollection)
				{
					comboBox_title.Items.Add(category.title);
				}
			}
			comboBox_result.SelectedIndex = 0;
		}

		private void OnCancel(object sender, EventArgs e)
		{
			if (_isEditorMode)
				this.DialogResult = DialogResult.Cancel;
			else
				this.Hide();
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_isEditorMode)
			{
				e.Cancel = true;
				this.Hide();
			}
		}

		private void TaskTime_OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		private void AddTask_OnClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(comboBox_title.Text) || string.IsNullOrWhiteSpace(textBox_content.Text) || string.IsNullOrWhiteSpace(textBox_time.Text))
			{
				MessageBox.Show("Missing time, title or content.", "Error");
			}
			else if (comboBox_result.SelectedIndex != 0 && string.IsNullOrWhiteSpace(textBox_defects.Text) && string.IsNullOrWhiteSpace(textBox_comment.Text))
			{
				MessageBox.Show("Missing defects or comment.", "Error");
			}
			else
			{
				Regex reg = new Regex(@ConfigSettings.GlobalSettings["DefectsRegex"]);
				if (!string.IsNullOrWhiteSpace(textBox_defects.Text) && !reg.IsMatch(textBox_defects.Text))
				{
					MessageBox.Show("Defects format mismatch.", "Error");
				}
				else
				{
					if (_isEditorMode)
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						int.TryParse(textBox_time.Text, out int time);
						foreach (string line in textBox_content.Lines)
							FormReference.MainForm.AddTask(comboBox_title.Text, line, time, (TaskResult)comboBox_result.SelectedIndex, textBox_defects.Text, textBox_comment.Text);
					}
				}
			}
		}

		private void Result_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			label_defects.Text = comboBox_result.SelectedIndex == 0 ? "Defects (Optional):" : "Defects:";
			label_comment.Text = comboBox_result.SelectedIndex == 0 ? "Comment (Optional):" : "Comment:";
		}
	}
}
