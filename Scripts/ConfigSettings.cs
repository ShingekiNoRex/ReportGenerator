using System;
using System.Collections.Generic;
using System.IO;

namespace ReportGenerator
{
	public class ConfigSettings
	{
		public static readonly Dictionary<string, string> Settings = new Dictionary<string, string>();
		public static readonly Dictionary<string, string> GlobalSettings = new Dictionary<string, string>();

		private const string _configFile = "ReportGenerator.cfg";
		private const string _configDefault = "Name=\nBuildInfoPath=\nTitlesPath=\nGlobalConfig=";

		public static void Load()
		{
			Settings.Clear();
			try
			{
				if (!File.Exists(_configFile))
					Reset();

				foreach (string line in File.ReadAllLines(_configFile))
				{
					if (line.Contains('='))
					{
						Settings.Add(line.Split('=')[0], line.Split('=')[1]);
					}
				}
			}
			catch
			{
				Reset();
			}
		}

		public static void Save(string name, string buildInfoPath, string titlesPath, string globalCfgPath)
		{
			File.WriteAllText(_configFile, "Name=" + name + "\nBuildInfoPath=" + buildInfoPath + "\nTitlesPath=" + titlesPath + "\nGlobalConfig=" + globalCfgPath);
			Load();
		}

		public static void Reset()
		{
			File.WriteAllText(_configFile, _configDefault);
		}
	}
}
