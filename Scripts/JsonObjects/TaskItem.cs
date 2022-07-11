namespace ReportGenerator
{
	public enum TaskResult
	{
		Passed = 0,
		Failed,
		Retest,
		Blocked,
		Dropped,
		End
	}

	public class TaskItem
	{
		public string content;
		public string comment;
		public string defects;
		public string reporter;
		public int time;
		public TaskResult result;

		public TaskItem(string content, int time, string reporter, TaskResult result = TaskResult.Passed, string defects = "", string comment = "")
		{
			this.content = content;
			this.time = time;
			this.reporter = reporter;
			this.result = result;
			this.defects = defects;
			this.comment = comment;
		}

		public bool Equals(string content)
		{
			return this.content.Equals(content);
		}

		public override bool Equals(object obj)
		{
			return obj is TaskItem other && Equals(other.content);
		}

		public override int GetHashCode()
		{
			return content.GetHashCode();
		}
	}
}
