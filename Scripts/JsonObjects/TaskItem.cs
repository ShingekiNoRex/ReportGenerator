namespace ReportGenerator
{
	public class TaskItem
	{
		public string content;
		public string comment;
		public int time;

		public TaskItem(string content, int time, string comment = "")
		{
			this.content = content;
			this.time = time;
			this.comment = comment;
		}
	}
}
