using System;
using System.Drawing;
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
				{
					if (!(comboBox_title.SelectedItem is Category selectedTitle))
						selectedTitle = new Category(comboBox_title.Text);

					foreach (string line in textBox_link.Lines)
						FormReference.MainForm.AddBug(selectedTitle, (BugType)comboBox_bugType.SelectedIndex, line);
				}
			}
		}

		private void OnDrawItem(object sender, DrawItemEventArgs e)
		{
			ComboBox combo = sender as ComboBox;
			string text = combo.Items[e.Index].ToString();
			Brush brush = Brushes.Black;

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				brush = Brushes.White;
				if (Screen.GetBounds(new Point(0, 0)).Bottom - PointToScreen(combo.Location).Y - combo.Height < combo.Items.Count * combo.ItemHeight)
					toolTip_title.Show(text, combo, e.Bounds.X + e.Bounds.Width, e.Bounds.Y - combo.Items.Count * e.Bounds.Height);
				else
					toolTip_title.Show(text, combo, e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height);
			}

			e.DrawBackground();
			e.Graphics.DrawString(text, combo.Font, brush, e.Bounds.X, e.Bounds.Y);
			e.DrawFocusRectangle();
		}

		private void OnDropDownClosed(object sender, EventArgs e)
		{
			toolTip_title.Hide(comboBox_title);
		}
	}
}
