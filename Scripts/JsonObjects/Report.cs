using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportGenerator
{
	public class Report
	{
		public string date;
		public BuildInfo buildInfo;
		public int installTime;
		public List<TestingItem> testings;

		public Report(string date, BuildInfo buildInfo, int installTime, List<TestingItem> testings)
		{
			this.date = date;
			this.buildInfo = buildInfo;
			this.installTime = installTime;
			this.testings = testings;
		}

		public void Combine(Report other)
		{
			if (other == null)
				return;

			date = CombineDate(date.Split(" - "), other.date.Split(" - "));
			buildInfo.Combine(other.buildInfo);
			installTime += other.installTime;
			foreach (TestingItem otherItem in other.testings)
			{
				int thisItemIndex = testings.FindIndex(x => x.Equals(otherItem));
				if (thisItemIndex < 0)
					testings.Add(otherItem);
				else
				{
					testings[thisItemIndex].tasks = new List<TaskItem>(testings[thisItemIndex].tasks.Concat(otherItem.tasks));
					testings[thisItemIndex].bugs = new List<BugItem>(testings[thisItemIndex].bugs.Concat(otherItem.bugs));
				}
			}
		}

		private string CombineDate(string[] date1, string[] date2)
		{
			if (date1.Length <= 0 || date2.Length <= 0)
				return string.Empty;

			DateTime dt1 = DateTime.ParseExact(date1[0], "M/d/yyyy", null);
			DateTime dt2 = date1.Length > 1 ? DateTime.ParseExact(date1[1], "M/d/yyyy", null) : dt1;
			DateTime dt3 = DateTime.ParseExact(date2[0], "M/d/yyyy", null);
			DateTime dt4 = date2.Length > 1 ? DateTime.ParseExact(date2[1], "M/d/yyyy", null) : dt3;

			DateTime fromDate = DateTime.Compare(dt1, dt3) > 0 ? dt3 : dt1;
			DateTime toDate = DateTime.Compare(dt2, dt4) > 0 ? dt2 : dt4;

			return DateTime.Compare(fromDate, toDate) == 0 ? fromDate.ToShortDateString() : fromDate.ToShortDateString() + " - " + toDate.ToShortDateString();
		}
	}
}
