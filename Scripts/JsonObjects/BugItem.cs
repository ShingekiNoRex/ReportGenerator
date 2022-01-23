namespace ReportGenerator
{
	public enum BugType
	{
		New = 0,
		Retested,
		Closed
	}

	public class BugItem
	{
		public string link;
		public BugType type;

		public BugItem(BugType type, string link)
		{
			this.type = type;
			this.link = link;
		}
	}
}
