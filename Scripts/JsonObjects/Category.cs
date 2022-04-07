namespace ReportGenerator
{
	public class Category
	{
		public string title;
		public string link;
		public bool isExploratory;

		public Category(string title, string link = "", bool isExploratory = false)
		{
			this.title = title;
			this.link = link;
			this.isExploratory = isExploratory;
		}

		public override string ToString()
		{
			return title;
		}
	}
}
