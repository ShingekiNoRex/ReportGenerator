namespace ReportGenerator
{
	public enum TaskResult
	{
		Pass = 0,
		Failed,
		Retest,
		Blocked
	}

	public class TaskItem
	{
		public string content;
		public string comment;
		public string defects;
		public string reporter;
		public int time;
		public TaskResult result;

		public TaskItem(string content, int time, string reporter, TaskResult result = TaskResult.Pass, string defects = "", string comment = "")
		{
			this.content = content;
			this.time = time;
			this.reporter = reporter;
			this.result = result;
			this.defects = defects;
			this.comment = comment;
		}
	}
}
