using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Utf8Json;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ReportGenerator
{
	public partial class MainForm : Form
	{
		public const string Version = "1.7";

		public BuildInfo[] BuildInfoCollection;
		public Category[] CategoriesCollection;

		private bool _fileSaved = true;
		private string _currentPath;
		private List<TestingItem> _testingItems = new List<TestingItem>();
		private List<BuildInfo> _selectedBuildInfo = new List<BuildInfo>();

		private readonly Color[] _resultColor = { Color.Green, Color.Red, Color.Gold, Color.Orange };

		public MainForm()
		{
			FormReference.MainForm = this;
			InitializeComponent();
			ConfigSettings.Load();
			InitializeComponent_Post();
			ValidateConfig();
		}

		#region Initialization
		private void InitializeComponent_Post()
		{
			dateTimePicker_to.Value = DateTime.Today;
			dateTimePicker_from.Value = DateTime.Today;
			this.Text = "Untitled - Report Generator " + Version;
		}

		private bool ValidateConfigSettings()
		{
			if (ConfigSettings.Settings.ContainsKey("Name") && !string.IsNullOrWhiteSpace(ConfigSettings.Settings["Name"]))
			{
				saveFileDialog_json.FileName = DateTime.Today.ToString("yyyy.M.d") + " - " + ConfigSettings.Settings["Name"];
				saveFileDialog_txt.FileName = DateTime.Today.ToString("yyyy.M.d") + " - " + ConfigSettings.Settings["Name"];
			}
			else
			{
				saveFileDialog_json.FileName = DateTime.Today.ToString("yyyy.M.d");
				saveFileDialog_txt.FileName = DateTime.Today.ToString("yyyy.M.d");
				return false;
			}
			

			if (!ConfigSettings.Settings.TryGetValue("BuildInfoPath", out string path) || !BuildInfoProcessor(path))
				return false;

			if (!ConfigSettings.Settings.TryGetValue("TitlesPath", out path) || !TitlesProcessor(path))
				return false;

			if (!ConfigSettings.Settings.TryGetValue("GlobalConfig", out path) || !GlobalConfigProcessor(path))
				return false;

			return true;
		}

		private bool BuildInfoProcessor(string path)
		{
			if (!File.Exists(path))
				return false;

			try
			{
				BuildInfoCollection = JsonSerializer.Deserialize<BuildInfo[]>(File.ReadAllBytes(path));
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error when loading BuildInfo:" + ex);
				return false;
			}

			return true;
		}

		private bool TitlesProcessor(string path)
		{
			if (!File.Exists(path))
				return false;

			try
			{
				CategoriesCollection = JsonSerializer.Deserialize<Category[]>(File.ReadAllBytes(path));
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error when loading Titles:" + ex);
				return false;
			}

			return true;
		}

		private bool GlobalConfigProcessor(string path)
		{
			if (!File.Exists(path))
				return false;

			try
			{
				ConfigSettings.GlobalSettings.Clear();
				foreach (string line in File.ReadAllLines(path))
				{
					if (line.Contains('='))
					{
						ConfigSettings.GlobalSettings.Add(line.Split('=')[0], line.Split('=')[1]);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error when loading GlobalConfig:" + ex);
				return false;
			}

			return true;
		}
		#endregion

		#region Actions
		private void AddTask_OnClick(object sender, EventArgs e)
		{
			if (FormReference.AddTaskForm == null)
			{
				FormReference.AddTaskForm = new Form_AddTask();
				FormReference.AddTaskForm.Show();
			}
			else if (!FormReference.AddTaskForm.Visible)
				FormReference.AddTaskForm.Show();
			else
				FormReference.AddTaskForm.Activate();
		}

		private void AddBug_OnClick(object sender, EventArgs e)
		{
			if (FormReference.AddBugForm == null)
			{
				FormReference.AddBugForm = new Form_AddBug();
				FormReference.AddBugForm.Show();
			}
			else if (!FormReference.AddBugForm.Visible)
				FormReference.AddBugForm.Show();
			else
				FormReference.AddBugForm.Activate();
		}

		private void HyperlinkRetriever_OnClick(object sender, EventArgs e)
		{
			if (FormReference.HyperlinkRetrieverForm == null)
			{
				FormReference.HyperlinkRetrieverForm = new Form_HyperlinkRetriever();
				FormReference.HyperlinkRetrieverForm.Show();
			}
			else if (!FormReference.HyperlinkRetrieverForm.Visible)
				FormReference.HyperlinkRetrieverForm.Show();
			else
				FormReference.HyperlinkRetrieverForm.Activate();
		}

		private void BuildInfoSelection_OnClick(object sender, EventArgs e)
		{
			Form_BuildInfoSelection form_buildSelection = new Form_BuildInfoSelection(_selectedBuildInfo);
			if (form_buildSelection.ShowDialog() == DialogResult.OK)
			{
				_selectedBuildInfo.Clear();
				foreach (int selection in form_buildSelection.checkedListBox_buildInfo.CheckedIndices)
				{
					_selectedBuildInfo.Add(BuildInfoCollection[selection]);
				}

				button_buildInfoSelection.Text = _selectedBuildInfo.Count > 0 ? (_selectedBuildInfo.Count > 1 ? "Multiple builds selected" : _selectedBuildInfo[0].ToString()) : "Select a build...";
				ReportChangedIndicate();
			}
		}

		private void ToDate_OnValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Compare(dateTimePicker_from.Value, dateTimePicker_to.Value) > 0)
				dateTimePicker_to.Value = dateTimePicker_from.Value;
		}

		private void FromDate_OnValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Compare(dateTimePicker_from.Value, dateTimePicker_to.Value) > 0)
				dateTimePicker_from.Value = dateTimePicker_to.Value;
		}

		private void InstallTime_OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		private void Options_OnClick(object sender, EventArgs e)
		{
			new Form_Options().ShowDialog();
		}

		private void TaskList_OnNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			// TODO
		}

		private void TaskList_OnAfterSelect(object sender, TreeViewEventArgs e)
		{
			button_edit.Enabled = e.Node.Level > 1;
			button_remove.Enabled = e.Node.Level > 1;
		}

		private void OnRemove(object sender, EventArgs e)
		{
			if (treeView_tasklist.SelectedNode.Level > 1)
				Remove(treeView_tasklist.SelectedNode);
		}

		private void OnEdit(object sender, EventArgs e)
		{
			if (treeView_tasklist.SelectedNode.Level > 1)
			{
				string title = treeView_tasklist.SelectedNode.Parent.Parent.Name;
				if (treeView_tasklist.SelectedNode.Tag is TaskItem taskItem)
				{
					Form_AddTask form_editTask = new Form_AddTask(title, taskItem);
					if (form_editTask.ShowDialog() == DialogResult.OK)
					{
						if (form_editTask.comboBox_title.Text.Equals(title))
						{
							taskItem.content = form_editTask.textBox_content.Lines[0];
							taskItem.defects = form_editTask.textBox_defects.Text;
							taskItem.comment = form_editTask.textBox_comment.Text;
							taskItem.result = (TaskResult)form_editTask.comboBox_result.SelectedIndex;

							int.TryParse(form_editTask.textBox_time.Text, out int time);
							taskItem.time = time;

							treeView_tasklist.SelectedNode.Text = string.Format("{0} ({1}) {2}m {3} {4}", taskItem.content, taskItem.result, taskItem.time, taskItem.defects, taskItem.comment);
							treeView_tasklist.SelectedNode.ForeColor = _resultColor[(int)taskItem.result];

							for (int i = 1; i < form_editTask.textBox_content.Lines.Length; i ++)
								AddTask(form_editTask.comboBox_title.Text, form_editTask.textBox_content.Lines[i], time, (TaskResult)form_editTask.comboBox_result.SelectedIndex, form_editTask.textBox_defects.Text, form_editTask.textBox_comment.Text, taskItem.reporter);
						}
						else
						{
							Remove(treeView_tasklist.SelectedNode);

							int.TryParse(form_editTask.textBox_time.Text, out int time);
							foreach (string line in form_editTask.textBox_content.Lines)
								AddTask(form_editTask.comboBox_title.Text, line, time, (TaskResult)form_editTask.comboBox_result.SelectedIndex, form_editTask.textBox_defects.Text, form_editTask.textBox_comment.Text, taskItem.reporter);
						}

						form_editTask.Close();
					}
				}
				else if (treeView_tasklist.SelectedNode.Tag is BugItem bugItem)
				{
					Form_AddBug form_editBug = new Form_AddBug(title, bugItem);
					if (form_editBug.ShowDialog() == DialogResult.OK)
					{
						if (form_editBug.comboBox_title.Text.Equals(title))
						{
							bugItem.link = form_editBug.textBox_link.Lines[0];
							bugItem.type = (BugType)form_editBug.comboBox_bugType.SelectedIndex;

							treeView_tasklist.SelectedNode.Text = bugItem.type.ToString() + " - " + bugItem.link;

							for (int i = 1; i < form_editBug.textBox_link.Lines.Length; i++)
								AddBug(form_editBug.comboBox_title.Text, (BugType)form_editBug.comboBox_bugType.SelectedIndex, form_editBug.textBox_link.Lines[i], bugItem.reporter);
						}
						else
						{
							Remove(treeView_tasklist.SelectedNode);

							foreach (string line in form_editBug.textBox_link.Lines)
								AddBug(form_editBug.comboBox_title.Text, (BugType)form_editBug.comboBox_bugType.SelectedIndex, line, bugItem.reporter);
						}

						form_editBug.Close();
					}
				}
				ReportChangedIndicate();
			}
		}

		private void Exit_OnClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Save_OnClick(object sender, EventArgs e)
		{
			SaveFile();
		}

		private void SaveAs_OnClick(object sender, EventArgs e)
		{
			if (_selectedBuildInfo.Count < 1)
			{
				MessageBox.Show("Missing build info.", "Error");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBox_installTime.Text))
			{
				MessageBox.Show("Missing build installation time.", "Error");
				return;
			}

			if (saveFileDialog_json.ShowDialog() == DialogResult.OK)
			{
				_currentPath = saveFileDialog_json.FileName;
				SaveAsJson(_currentPath);
			}
		}

		private void OnReportChanged(object sender, EventArgs e)
		{
			ReportChangedIndicate();
		}

		private void NewFile_OnClick(object sender, EventArgs e)
		{
			if (!_fileSaved)
			{
				switch (AskForSavingChanges())
				{
					case DialogResult.Yes:
						{
							SaveFile();
							ResetAll();
							break;
						}
					case DialogResult.No:
						{
							ResetAll();
							break;
						}
					case DialogResult.Cancel:
						{
							break;
						}
				}
			}
			else
				ResetAll();
		}

		private void OpenFile_OnClick(object sender, EventArgs e)
		{
			if (!_fileSaved)
			{
				switch (AskForSavingChanges())
				{
					case DialogResult.Yes:
						{
							SaveFile();
							LoadJson();
							break;
						}
					case DialogResult.No:
						{
							LoadJson();
							break;
						}
					case DialogResult.Cancel:
						{
							break;
						}
				}
			}
			else
				LoadJson();
		}

		private void GenerateTxtFile_OnClick(object sender, EventArgs e)
		{
			if (_selectedBuildInfo.Count < 1)
			{
				MessageBox.Show("Missing build info.", "Error");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBox_installTime.Text))
			{
				MessageBox.Show("Missing build installation time.", "Error");
				return;
			}

			if (saveFileDialog_txt.ShowDialog() == DialogResult.OK)
			{
				int totalTasks = 0, totalTime = 0;
				int[] bugAmount = CalculateBugAmount();
				Regex reg = new Regex(@ConfigSettings.GlobalSettings["DefectsRegex"]);

				foreach (BuildInfo buildInfo in _selectedBuildInfo)
				{
					string.Format("{0}.{1} CL {2} ({3})", buildInfo.branch, buildInfo.build, buildInfo.cl, buildInfo.environment);
				}

				StreamWriter sw = new StreamWriter(saveFileDialog_txt.FileName, false);
				sw.WriteLine(dateTimePicker_from.Text.Equals(dateTimePicker_to.Text) ? dateTimePicker_from.Text : dateTimePicker_from.Text + " - " + dateTimePicker_to.Text);
				sw.WriteLine("Tests executed in: ");
				foreach (BuildInfo buildInfo in _selectedBuildInfo)
				{
					sw.WriteLine(string.Format("{0}.{1} CL {2} ({3})", buildInfo.branch, buildInfo.build, buildInfo.cl, buildInfo.environment));
				}
				sw.WriteLine();

				foreach (var testingItem in _testingItems)
				{
					int thisTotalTime = testingItem.GetTotalTime();
					totalTasks += testingItem.tasks.Count;
					totalTime += thisTotalTime;

					if (thisTotalTime > 0)
						sw.WriteLine(string.Format("{0}: {1} ({2}m)", testingItem.category.title, testingItem.tasks.Count > 0 ? testingItem.tasks.Count.ToString() : string.Empty, thisTotalTime));
					else
						sw.WriteLine(string.Format("{0}: {1}", testingItem.category.title, testingItem.tasks.Count > 0 ? testingItem.tasks.Count.ToString() : string.Empty));

					foreach (var task in testingItem.tasks)
					{
						if (!string.IsNullOrWhiteSpace(task.defects))
						{
							string defects = "";
							foreach (Match match in reg.Matches(task.defects))
							{
								defects = string.Format("{0} [{1}|{2}{1}]", defects, match.Value, ConfigSettings.GlobalSettings["DefectsLink"]);
							}
							sw.WriteLine(string.Format("{0} ({1}) {2}m {3} {4}", task.content, task.result, task.time, defects, task.comment));
						}
						else
							sw.WriteLine(string.Format("{0} ({1}) {2}m {3}", task.content, task.result, task.time, task.comment));
					}

					if (testingItem.bugs.Count > 0)
					{
						sw.WriteLine("Bug(s): " + testingItem.bugs.Count);
						foreach (var bug in testingItem.bugs)
							sw.WriteLine(string.Format("{0} ({1})", bug.link, bug.type.ToString()));
					}

					sw.WriteLine();
				}

				sw.WriteLine("Build installation time: " + textBox_installTime.Text + "m");
				sw.WriteLine(string.Format("Number of tests executed: {0} ({1}m)", totalTasks, totalTime));
				sw.WriteLine(string.Format("Number of bugs found {0}, reopened {1}, closed {2}", bugAmount[0], bugAmount[1], bugAmount[2]));
				sw.Close();
			}
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_fileSaved)
			{
				switch (AskForSavingChanges())
				{
					case DialogResult.Yes:
						{
							e.Cancel = !SaveFile();
							break;
						}
					case DialogResult.No:
						{
							e.Cancel = false;
							break;
						}
					case DialogResult.Cancel:
						{
							e.Cancel = true;
							break;
						}
				}
			}
			else
				e.Cancel = false;
		}
		#endregion

		#region Public Methods
		public void AddTask(Category category, string content, int time, TaskResult result = TaskResult.Pass, string defects = "", string comment = "", string reporter = "")
		{
			AddTask(category.title, content, time, result, defects, comment, reporter);
		}

		public void AddTask(string title, string content, int time, TaskResult result = TaskResult.Pass, string defects = "", string comment = "", string reporter = "")
		{
			if (string.IsNullOrWhiteSpace(content))
				return;

			TaskItem taskItem = new TaskItem(content, time, string.IsNullOrWhiteSpace(reporter) ? ConfigSettings.Settings["Name"] : reporter, result, defects, comment);
			TreeNode node = new TreeNode(string.Format("{0} ({1}) {2}m {3} {4}", content, result, time, defects, comment))
			{
				Tag = taskItem,
				ForeColor = _resultColor[(int)result],
			};

			if (treeView_tasklist.Nodes.ContainsKey(title))
			{
				TestingItem testingItem = _testingItems.Find(item => item.Equals(title));
				if (testingItem.tasks.Contains(taskItem))
					node.Text = "*DUPLICATE* " + node.Text;

				testingItem.tasks.Add(taskItem);

				if (treeView_tasklist.Nodes[title].Nodes.ContainsKey("Tasks"))
					treeView_tasklist.Nodes[title].Nodes["Tasks"].Nodes.Add(node);
				else
					treeView_tasklist.Nodes[title].Nodes.Add("Tasks", "Tasks").Nodes.Add(node);
			}
			else
			{
				TestingItem testingItem = new TestingItem(title);
				testingItem.tasks.Add(taskItem);
				_testingItems.Add(testingItem);
				treeView_tasklist.Nodes.Add(title, title).Nodes.Add("Tasks", "Tasks").Nodes.Add(node);
			}
			node.ToolTipText = "Reported by " + taskItem.reporter;
			node.Parent.Expand();
			node.Parent.Parent.Expand();

			ReportChangedIndicate();
		}

		public void AddBug(Category category, BugType bugType, string link, string reporter = "")
		{
			AddBug(category.title, bugType, link, reporter);
		}

		public void AddBug(string title, BugType bugType, string link, string reporter = "")
		{
			if (string.IsNullOrWhiteSpace(link))
				return;

			BugItem bugItem = new BugItem(bugType, link, string.IsNullOrWhiteSpace(reporter) ? ConfigSettings.Settings["Name"] : reporter);
			TreeNode node = new TreeNode(string.Format("{0} - {1}", bugType, link))
			{
				Tag = bugItem
			};

			if (treeView_tasklist.Nodes.ContainsKey(title))
			{
				TestingItem testingItem = _testingItems.Find(item => item.Equals(title));
				if (testingItem.bugs.Contains(bugItem))
					node.Text = "*DUPLICATE* " + node.Text;

				testingItem.bugs.Add(bugItem);

				if (treeView_tasklist.Nodes[title].Nodes.ContainsKey("Bugs"))
					treeView_tasklist.Nodes[title].Nodes["Bugs"].Nodes.Add(node);
				else
					treeView_tasklist.Nodes[title].Nodes.Add("Bugs", "Bugs").Nodes.Add(node);
			}
			else
			{
				TestingItem testingItem = new TestingItem(title);
				testingItem.bugs.Add(bugItem);
				_testingItems.Add(testingItem);

				treeView_tasklist.Nodes.Add(title, title).Nodes.Add("Bugs", "Bugs").Nodes.Add(node);
			}
			node.ToolTipText = "Reported by " + bugItem.reporter;
			node.Parent.Expand();
			node.Parent.Parent.Expand();

			ReportChangedIndicate();
		}

		public void ValidateConfig()
		{
			if (!ValidateConfigSettings())
			{
				MessageBox.Show("Failed to validate config settings.", "Failed to load");
				new Form_Options().ShowDialog();
			}
		}
		#endregion

		#region Private Methods
		private void Remove(TreeNode selectedNode)
		{
			TestingItem testingItem = _testingItems.Find(item => item.Equals(selectedNode.Parent.Parent.Name));
			if (selectedNode.Tag is TaskItem taskItem)
			{
				testingItem.tasks.Remove(taskItem);
				Debug.WriteLine("Task removed:" + taskItem.content + " remaining:" + testingItem.tasks.Count);
			}
			else if (selectedNode.Tag is BugItem bugItem)
			{
				testingItem.bugs.Remove(bugItem);
				Debug.WriteLine("Bug removed:" + bugItem.link + " remaining:" + testingItem.bugs.Count);
			}

			if (testingItem.bugs.Count <= 0 && testingItem.tasks.Count <= 0)
			{
				_testingItems.Remove(testingItem);
				selectedNode.Parent.Parent.Remove();
			}
			else
			{
				if (selectedNode.Parent.Nodes.Count <= 1)
					selectedNode.Parent.Remove();
				else
					selectedNode.Remove();
			}

			button_edit.Enabled = treeView_tasklist.SelectedNode != null && treeView_tasklist.SelectedNode.Level > 1;
			button_remove.Enabled = treeView_tasklist.SelectedNode != null && treeView_tasklist.SelectedNode.Level > 1;
			ReportChangedIndicate();
		}

		private void SaveAsJson(string path)
		{
			string date = dateTimePicker_from.Text.Equals(dateTimePicker_to.Text) ? dateTimePicker_from.Text : dateTimePicker_from.Text + " - " + dateTimePicker_to.Text;
			int.TryParse(textBox_installTime.Text, out int time);
			Report report = new Report(date, _selectedBuildInfo, time, _testingItems);
			File.WriteAllBytes(path, JsonSerializer.Serialize(report));

			this.Text = Path.GetFileNameWithoutExtension(path) + " - Report Generator " + Version;
			_fileSaved = true;
			Debug.WriteLine("File saved as " + path);
		}

		private bool SaveFile()
		{
			if (_selectedBuildInfo.Count < 1)
			{
				MessageBox.Show("Missing build info.", "Error");
				return false;
			}

			if (string.IsNullOrWhiteSpace(textBox_installTime.Text))
			{
				MessageBox.Show("Missing build installation time.", "Error");
				return false;
			}

			if (_fileSaved)
				return true;

			if (string.IsNullOrWhiteSpace(_currentPath))
			{
				if (saveFileDialog_json.ShowDialog() == DialogResult.OK)
				{
					_currentPath = saveFileDialog_json.FileName;
					SaveAsJson(_currentPath);
				}
				else
					return false;
			}
			else
			{
				SaveAsJson(_currentPath);
			}
			return true;
		}

		private void ReportChangedIndicate()
		{
			if (_fileSaved)
			{
				this.Text = "*" + this.Text;
				_fileSaved = false;
			}
		}

		private void ResetAll()
		{
			button_buildInfoSelection.Text = "Select a build...";
			textBox_installTime.Text = "";
			treeView_tasklist.Nodes.Clear();
			_testingItems.Clear();
			_selectedBuildInfo.Clear();
			_fileSaved = true;
			_currentPath = "";
			InitializeComponent_Post();
		}

		private void LoadJson()
		{
			ResetAll();
			if (openFileDialog_json.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string fileNames = "";
					Report report = null;
					foreach (string path in openFileDialog_json.FileNames)
					{
						if (report == null)
						{
							fileNames = Path.GetFileNameWithoutExtension(path);
							report = JsonSerializer.Deserialize<Report>(File.ReadAllBytes(path));
						}
						else
						{
							fileNames = fileNames + " + " + Path.GetFileNameWithoutExtension(path);
							report.Combine(JsonSerializer.Deserialize<Report>(File.ReadAllBytes(path)));
						}
					}

					if (report == null || string.IsNullOrWhiteSpace(report.date))
					{
						MessageBox.Show("Failed to load report.", "Error");
						return;
					}

					LoadReport(report);

					this.Text = fileNames + " - Report Generator " + Version;
					if (openFileDialog_json.FileNames.Length > 1)
					{
						_currentPath = "";
						ReportChangedIndicate();
					}
					else
					{
						_fileSaved = true;
						_currentPath = openFileDialog_json.FileName;
					}
				}
				catch(Exception ex)
				{
					Debug.WriteLine("Failed to load: " + ex);
				}
			}
		}

		private void LoadReport(Report report)
		{
			if (report.date.Contains(" - "))
			{
				dateTimePicker_from.Value = DateTime.ParseExact(report.date.Split(" - ")[0], "M/d/yyyy", null);
				dateTimePicker_to.Value = DateTime.ParseExact(report.date.Split(" - ")[1], "M/d/yyyy", null);
			}
			else
			{
				dateTimePicker_from.Value = DateTime.ParseExact(report.date, "M/d/yyyy", null);
				dateTimePicker_to.Value = dateTimePicker_from.Value;
			}

			if (report.buildInfo.Count > 0)
			{
				if (BuildInfoCollection == null)
				{
					BuildInfoCollection = new BuildInfo[report.buildInfo.Count];

					for (int i = 0; i < report.buildInfo.Count; i++)
						BuildInfoCollection[i] = report.buildInfo[i];
				}
				else
				{
					foreach (var buildInfo in report.buildInfo)
					{
						int buildInfoIndex = new List<BuildInfo>(BuildInfoCollection).FindIndex(x => x.Equals(buildInfo));
						if (buildInfoIndex < 0)
						{
							BuildInfo[] newCollection = new BuildInfo[BuildInfoCollection.Length + 1];
							BuildInfoCollection.CopyTo(newCollection, 0);
							newCollection[BuildInfoCollection.Length] = buildInfo;
							BuildInfoCollection = newCollection;
						}
					}
				}
				_selectedBuildInfo = report.buildInfo;
				button_buildInfoSelection.Text = report.buildInfo.Count > 1 ? "Multiple builds selected" : report.buildInfo[0].ToString();
			}

			textBox_installTime.Text = report.installTime.ToString();

			foreach (var testingItem in report.testings)
			{
				foreach (var task in testingItem.tasks)
					AddTask(testingItem.category, task.content, task.time, task.result, task.defects, task.comment, task.reporter);
				foreach (var bug in testingItem.bugs)
					AddBug(testingItem.category, bug.type, bug.link, bug.reporter);
			}
		}

		private DialogResult AskForSavingChanges()
		{
			string filename = string.IsNullOrWhiteSpace(_currentPath) ? "Untitled" : Path.GetFileName(_currentPath);
			return MessageBox.Show("Do you want to save changes to " + filename + "?", "Report Generator", MessageBoxButtons.YesNoCancel);
		}

		private int[] CalculateBugAmount()
		{
			int[] bugAmount = new int[3];
			foreach (var testingItem in _testingItems)
				foreach (var bug in testingItem.bugs)
					bugAmount[(int)bug.type]++;

			return bugAmount;
		}
		#endregion
	}
}
