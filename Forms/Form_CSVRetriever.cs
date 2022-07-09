using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReportGenerator
{
	public partial class Form_CSVRetriever : Form
	{
		public DataTable CSVTable;

		public Form_CSVRetriever()
		{
			Initialize();
		}

		private void Initialize()
		{
			InitializeComponent();
			if (FormReference.MainForm.CategoriesCollection != null)
			{
				foreach (Category category in FormReference.MainForm.CategoriesCollection)
				{
					comboBox_title.Items.Add(category);
				}
			}
		}

		private void LoadCSV_OnClick(object sender, System.EventArgs e)
		{
			if (openFileDialog_csv.ShowDialog() == DialogResult.OK)
			{
				try
				{
					CSVTable = CSVRetriever.RetrieveCSVFromFile(openFileDialog_csv.FileName);
					if (CSVTable == null)
					{
						MessageBox.Show("Failed to validate CSV table.", "Error");
						return;
					}

					dataGridView_csv.DataSource = CSVTable;
				}
				catch (Exception ex)
				{
					Debug.WriteLine("Failed to load CSV: " + ex);
				}
			}
		}

		private void AddTask_OnClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(comboBox_title.Text))
			{
				MessageBox.Show("Missing title.", "Error");
				return;
			}

			if (!(comboBox_title.SelectedItem is Category selectedTitle))
				selectedTitle = new Category(comboBox_title.Text);

			string invalidRows = "";
			for (int i = 0; i < CSVTable.Rows.Count; i++)
			{
				DataRow row = CSVTable.Rows[i];
				string id = row["ID"].ToString();
				string status = row["Status"].ToString();
				string comment = row["Comment"].ToString();
				string defects = row["Defects"].ToString();

				if (string.IsNullOrWhiteSpace(id))
				{
					invalidRows += " " + i;
					continue;
				}

				if (!Enum.TryParse(status, out TaskResult result))
				{
					invalidRows += " " + i;
					continue;
				}

				if (result != TaskResult.Passed)
				{
					if (string.IsNullOrWhiteSpace(comment) && string.IsNullOrWhiteSpace(defects))
					{
						invalidRows += " " + i;
						continue;
					}
				}

				int.TryParse(row["Elapsed"].ToString().TrimEnd('s'), out int elapsed);
				elapsed /= 60;

				FormReference.MainForm.AddTask(selectedTitle, id, elapsed, result, defects, comment);
			}

			if (!string.IsNullOrWhiteSpace(invalidRows))
				MessageBox.Show("Missing content on line: " + invalidRows, "Error");
		}
	}
}
