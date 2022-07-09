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

		public bool Equals(string title)
		{
			return this.title.Equals(title);
		}

		public override bool Equals(object obj)
		{
			return obj is Category other && Equals(other.title);
		}

		public override int GetHashCode()
		{
			return title.GetHashCode();
		}
	}
}
