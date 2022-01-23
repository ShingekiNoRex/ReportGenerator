using System.Windows.Forms;

namespace ReportGenerator
{
	public class FormReference
	{
		public static MainForm MainForm { get; set; }

		public static Form_AddTask AddTaskForm { get; set; }

		public static Form_AddBug AddBugForm { get; set; }
	}
}
