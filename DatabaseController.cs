using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSP_Analyze
{
    public class DatabaseController
    {
        public string CurrentQueryName;
        public string RemoteLastUpdated = "Never";

        public static int MATCHSCOUTING_COLUMNS = 85;
        public static int PITSCOUTING_COLUMNS = 39;

        public const int SUCCESS = 0;
        public const int ERROR_INVALID_FILENAME = 1;
        public const int ERROR_FILE_ALREADY_EXISTS = 2;
        public const int ERROR_INVALID_PERMISSION = 3;

        public readonly string rootFolderPath;
        public readonly string infoFilePath;

        private readonly string matchscoutingSavedPath;
        private readonly string pitscoutingSavedPath;
        private readonly string mobileImportsPath;

        public CspAnalyzeDataSet.matchscoutingDataTable matchscoutingDataTable;
        public CspAnalyzeDataSetTableAdapters.matchscoutingTableAdapter matchscoutingTableAdapter;

        public CspAnalyzeDataSet.pitscoutingDataTable pitscoutingDataTable;
        public CspAnalyzeDataSetTableAdapters.pitscoutingTableAdapter pitscoutingTableAdapter;

        public DatabaseController()
        {
            rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CSP");
            Directory.CreateDirectory(rootFolderPath);
            infoFilePath = Path.Combine(rootFolderPath, "info.cfg");
            matchscoutingSavedPath = Path.Combine(rootFolderPath, "matchscouting.xml");
            pitscoutingSavedPath = Path.Combine(rootFolderPath, "pitscouting.xml");
            mobileImportsPath = Path.Combine(rootFolderPath, "mobile_imports");
            Directory.CreateDirectory(mobileImportsPath);

            matchscoutingDataTable = new CspAnalyzeDataSet.matchscoutingDataTable();
            matchscoutingTableAdapter = new CspAnalyzeDataSetTableAdapters.matchscoutingTableAdapter();

            pitscoutingDataTable = new CspAnalyzeDataSet.pitscoutingDataTable();
            pitscoutingTableAdapter = new CspAnalyzeDataSetTableAdapters.pitscoutingTableAdapter();

            AttemptInfoFileLoad();
        }

        private void AttemptInfoFileLoad()
        {
            if (File.Exists(infoFilePath))
            {
                foreach (string line in File.ReadLines(infoFilePath))
                {
                    if (line.IndexOf("remote_last_updated") >= 0)
                    {
                        RemoteLastUpdated = line.Substring(line.IndexOf("=") + 1);
                        continue;
                    }
                }
            }
            else
            {
                // set default settings
                SaveInfo();
            }

            try
            {
                matchscoutingDataTable.ReadXml(matchscoutingSavedPath);
            }
            catch (Exception) {}
        }

        private void SaveInfo()
        {
            File.WriteAllText(infoFilePath, "remote_last_updated=" + RemoteLastUpdated);

            try
            {
                matchscoutingDataTable.WriteXml(matchscoutingSavedPath);
            }
            catch (Exception) {}
        }

        public void ImportPitScoutingRows(LinkedList<string> pits)
        {
            DataColumnCollection columns = pitscoutingDataTable.Columns;
            Regex dateRegex = new Regex("(\\d+)\\/(\\d+)\\/(\\d+)\\+? ?(\\d+):(\\d+):(\\d+)", RegexOptions.Compiled);

            foreach (string pit in pits)
            {
                string[] values = pit.Split(',');
                DataRow newPit = pitscoutingDataTable.NewRow();

                // Add columns from match scouting
                for (int i = 1; i < values.Length; i++)
                {
                    string columnName = columns[i].ColumnName.ToString();
                    string value = values[i];

                    if (columnName.IndexOf("dt") >= 0)
                    {
                        // this is a date. we need to parse value and turn it into a datetime object
                        Match dateMatches = dateRegex.Match(value);
                        GroupCollection groups = dateMatches.Groups;
                        int[] dateMatchResults = new int[groups.Count];
                        for (int j = 1; j < dateMatchResults.Length; j++)
                        {
                            dateMatchResults[j - 1] = int.Parse(groups[j].Value);
                        }

                        // year month day hour minute second
                        DateTime dateTime = new DateTime(dateMatchResults[0], dateMatchResults[1], dateMatchResults[2], dateMatchResults[3], dateMatchResults[4], dateMatchResults[5]);
                        newPit[columnName] = dateTime;
                        Console.WriteLine("Set " + columnName + " to " + dateTime);
                    }
                    else
                    {
                        newPit[columnName] = value;
                        Console.WriteLine("Set " + columnName + " to " + value);
                    }
                }

                // Add rows
                pitscoutingDataTable.Rows.Add(newPit);
            }
        }

        public void ImportMatchScoutingRows(LinkedList<string> matches)
        {
            DataColumnCollection columns = matchscoutingDataTable.Columns;
            Regex dateRegex = new Regex("(\\d+)\\/(\\d+)\\/(\\d+)\\+? ?(\\d+):(\\d+):(\\d+)", RegexOptions.Compiled);

            foreach (string match in matches)
            {
                string[] values = match.Split(',');
                DataRow newMatch = matchscoutingDataTable.NewRow();

                // Add columns from match scouting
                for (int i = 1; i < values.Length; i++)
                {
                    string columnName = columns[i].ColumnName.ToString();
                    string value = values[i];

                    if (columnName.IndexOf("dt") >= 0)
                    {
                        // this is a date. we need to parse value and turn it into a datetime object
                        Match dateMatches = dateRegex.Match(value);
                        GroupCollection groups = dateMatches.Groups;
                        int[] dateMatchResults = new int[groups.Count];
                        for (int j = 1; j < dateMatchResults.Length; j++)
                        {
                            dateMatchResults[j-1] = int.Parse(groups[j].Value);
                        }

                        // year month day hour minute second
                        DateTime dateTime = new DateTime(dateMatchResults[0], dateMatchResults[1], dateMatchResults[2], dateMatchResults[3], dateMatchResults[4], dateMatchResults[5]);
                        newMatch[columnName] = dateTime;
                        Console.WriteLine("Set " + columnName + " to " + dateTime);
                    }
                    else
                    {
                        newMatch[columnName] = value;
                        Console.WriteLine("Set " + columnName + " to " + value);
                    }
                }

                // Add rows
                matchscoutingDataTable.Rows.Add(newMatch);
            }
        }

        public int CreateQueryFile(string queryName, string contents)
        {
            string newFileName = queryName + ".cspq";
            string newQueryPath = Path.Combine(rootFolderPath, newFileName);
            if (newFileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) return ERROR_INVALID_FILENAME;
            if (File.Exists(newQueryPath)) return ERROR_FILE_ALREADY_EXISTS;
            
            try
            {
                File.WriteAllText(newQueryPath, contents);
                CurrentQueryName = queryName;
                return SUCCESS;
            } catch (Exception)
            {
                return ERROR_INVALID_PERMISSION;
            }
        }

        public int SaveQueryFile(string contents)
        {
            if (string.IsNullOrEmpty(CurrentQueryName))
            {
                return ERROR_INVALID_FILENAME;
            }

            string newFileName = CurrentQueryName + ".cspq";
            string newQueryPath = Path.Combine(rootFolderPath, newFileName);

            try
            {
                File.WriteAllText(newQueryPath, contents);
                return SUCCESS;
            } catch (Exception)
            {
                return ERROR_INVALID_PERMISSION;
            }
        }

        public string RemotePull()
        {
            int matchResult, pitResult;
            try
            {
                matchResult = matchscoutingTableAdapter.Fill(matchscoutingDataTable);
                pitResult = pitscoutingTableAdapter.Fill(pitscoutingDataTable);
            }
            catch (SqlException e)
            {
                return "An error occurred: " + e.Message;
            }
            

            try
            {
                matchscoutingDataTable.WriteXml(matchscoutingSavedPath);
                pitscoutingDataTable.WriteXml(pitscoutingSavedPath);
            }
            catch (Exception) {}

            SaveInfo();

            return string.Format("{0} match rows, {1} pit rows affected by the pull.", matchResult, pitResult);
        }

        public string RemotePush()
        {
            matchscoutingTableAdapter.Update(matchscoutingDataTable);
            pitscoutingTableAdapter.Update(pitscoutingDataTable);
            SaveInfo();
            return string.Format("Pushed.");
        }
    }
}
