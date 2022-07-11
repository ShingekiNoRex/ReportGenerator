using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ReportGenerator
{
	public class CSVRetriever
	{
		public static DataTable RetrieveCSVFromFile(string filename)
		{
			try
			{
				DataTable dt = new DataTable();

				StreamReader sr = new StreamReader(filename);

				string tempText = "";
				bool isFirst = true;
				while ((tempText = sr.ReadLine()) != null)
				{
                    string[] arr = CSVstrToArray(tempText);

                    if (isFirst)
					{
						foreach (string str in arr)
							dt.Columns.Add(str);

						if (!dt.Columns.Contains("ID") || !dt.Columns.Contains("Comment") || !dt.Columns.Contains("Elapsed") || !dt.Columns.Contains("Defects") || !dt.Columns.Contains("Status"))
						{
							sr.Close();
							return null;
						}

						isFirst = false;
					}
					else
					{
						DataRow dr = dt.NewRow();
						for (int i = 0; i < dt.Columns.Count; i++)
							dr[i] = i < arr.Length ? arr[i] : "";

						dt.Rows.Add(dr);
					}
				}

				sr.Close();
				return dt;
			}
			catch
			{
				return null;
			}
		}

        public static DataTable RetrieveTableFromClipboard()
		{
            try
            {
                string tempText = Clipboard.GetText();
                if (string.IsNullOrWhiteSpace(tempText))
                    return null;

                DataTable dt = new DataTable();

                bool isFirst = true;
                foreach (string line in tempText.Trim().Split('\n'))
				{
                    string[] arr = line.Split('\t');
                    if (isFirst)
					{
                        foreach (string str in arr)
                            dt.Columns.Add(str);

                        if (!dt.Columns.Contains("ID") || !dt.Columns.Contains("Comment") || !dt.Columns.Contains("Elapsed") || !dt.Columns.Contains("Defects") || !dt.Columns.Contains("Status"))
                            return null;

                        isFirst = false;
					}
                    else
					{
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dt.Columns.Count; i++)
                            dr[i] = i < arr.Length ? arr[i] : "";

                        dt.Rows.Add(dr);
                    }
				}
                return dt;
            }
            catch
			{
                return null;
			}
        }

        private static string[] CSVstrToArray(string splitStr)
        {
            var newstr = string.Empty;
            List<string> sList = new List<string>();

            bool isSplice = false;
            string[] array = splitStr.Split(new char[] { ',' });
            foreach (var str in array)
            {
                if (!string.IsNullOrEmpty(str) && str.IndexOf('"') > -1)
                {
                    var firstchar = str.Substring(0, 1);
                    var lastchar = string.Empty;
                    if (str.Length > 0)
                    {
                        lastchar = str.Substring(str.Length - 1, 1);
                    }
                    if (firstchar.Equals("\"") && !lastchar.Equals("\""))
                    {
                        isSplice = true;
                    }
                    if (lastchar.Equals("\""))
                    {
                        if (!isSplice)
                            newstr += str;
                        else
                            newstr = newstr + "," + str;

                        isSplice = false;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(newstr))
                        newstr += str;
                }

                if (isSplice)
                {
                    if (string.IsNullOrEmpty(newstr))
                        newstr += str;
                    else
                        newstr = newstr + "," + str;
                }
                else
                {
                    sList.Add(newstr.Replace("\"", "").Trim());
                    newstr = string.Empty;
                }
            }
            return sList.ToArray();
        }
	}
}
