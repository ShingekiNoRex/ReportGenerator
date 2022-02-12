namespace ReportGenerator
{
	public enum BugType
	{
		New = 0,
		Reopened,
		Closed
	}

	public class BugItem
	{
		public string link;
		public BugType type;
		public string reporter;

		public BugItem(BugType type, string link, string reporter)
		{
			this.type = type;
			this.link = link;
			this.reporter = reporter;
		}

		public bool Equals(string link)
		{
			return this.link.Equals(link);
		}

		public override bool Equals(object obj)
		{
			return obj is BugItem other && Equals(other.link);
		}

		public override int GetHashCode()
		{
			return link.GetHashCode();
		}
	}
}
