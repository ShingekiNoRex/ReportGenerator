using System;
using System.Collections.Generic;

namespace ReportGenerator
{
	public class TestingItem
	{
		public Category category;
		public List<TaskItem> tasks;
		public List<BugItem> bugs;

		public TestingItem(Category category)
		{
			this.category = category;
			this.tasks = new List<TaskItem>();
			this.bugs = new List<BugItem>();
		}

		public TestingItem(string title)
		{
			this.category = new Category(title);
			this.tasks = new List<TaskItem>();
			this.bugs = new List<BugItem>();
		}

		public int GetTotalTime()
		{
			int time = 0;
			foreach (var task in tasks)
				time += task.time;

			return time;
		}

		public bool Equals(string title)
		{
			return category.title.Equals(title);
		}

		public override bool Equals(object obj)
		{
			return obj is TestingItem other && Equals(other.category.title);
		}

		public override int GetHashCode()
		{
			return category.title.GetHashCode();
		}
	}
}
