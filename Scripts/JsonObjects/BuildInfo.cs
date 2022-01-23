namespace ReportGenerator
{
	public class BuildInfo
	{
		public string branch;
		public string build;
		public string cl;
		public string environment;

		public BuildInfo(string branch, string build, string cl, string environment)
		{
			this.branch = branch;
			this.build = build;
			this.cl = cl;
			this.environment = environment;
		}

		public void Combine(BuildInfo other)
		{
			if (!branch.Contains(other.branch))
				branch = branch + "&" + other.branch;

			if (!build.Contains(other.build))
				build = build + "&" + other.build;

			if (!cl.Contains(other.cl))
				cl = cl + "&" + other.cl;

			if (!environment.Contains(other.environment))
				environment = environment + "&" + other.environment;
		}

		public bool Equals(string branch, string build, string cl, string environment)
		{
			return this.branch.Equals(branch) && this.build.Equals(build) && this.cl.Equals(cl) && this.environment.Equals(environment);
		}

		public bool Equals(BuildInfo buildInfo)
		{
			return this.branch.Equals(buildInfo.branch) && this.build.Equals(buildInfo.build) && this.cl.Equals(buildInfo.cl) && this.environment.Equals(buildInfo.environment);
		}

		public override bool Equals(object obj)
		{
			return obj is BuildInfo other && Equals(other);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = branch.GetHashCode();
				hashCode = (hashCode * 397) ^ build.GetHashCode();
				hashCode = (hashCode * 397) ^ cl.GetHashCode();
				hashCode = (hashCode * 397) ^ environment.GetHashCode();
				return hashCode;
			}
		}
	}
}
