using System;

namespace ReportGenerator
{
	[Flags]
	public enum Platform
	{
		PC = 1 << 0,
		Android = 1 << 1,
		iOS = 1 << 2,
	}

	public class BuildInfo
	{
		public string branch;
		public string build;
		public string cl;
		public string environment;
		public Platform platform;

		public BuildInfo(string branch, string build, string cl, string environment, Platform platform = Platform.PC)
		{
			this.branch = branch;
			this.build = build;
			this.cl = cl;
			this.environment = environment;
			this.platform = platform;
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

		public override string ToString()
		{
			return string.Format("{0}.{1} CL {2} ({3})", branch, build, cl, environment);
		}
	}
}
