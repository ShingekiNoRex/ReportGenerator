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
		public int time;
		public TaskResult result;

		public TaskItem(string content, int time, TaskResult result = TaskResult.Pass, string comment = "")
		{
			this.content = content;
			this.time = time;
			this.result = result;
			this.comment = comment;
		}
	}
}
