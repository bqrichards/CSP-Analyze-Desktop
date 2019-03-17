﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_Analyze
{
    class DatabaseController
    {
        public string CurrentQueryName;
        public string RemoteLastUpdated = "Never";

        public static int MATCHSCOUTING_COLUMNS = 85;

        public const int SUCCESS = 0;
        public const int ERROR_INVALID_FILENAME = 1;
        public const int ERROR_FILE_ALREADY_EXISTS = 2;
        public const int ERROR_INVALID_PERMISSION = 3;

        public readonly string rootFolderPath;
        public readonly string infoFilePath;

        private readonly string matchscoutingSavedPath;

        private CspAnalyzeDataSet.matchscoutingDataTable matchscoutingDataTable;
        private CspAnalyzeDataSetTableAdapters.matchscoutingTableAdapter matchscoutingTableAdapter;

        public int numberOfLocalMatchScoutingChanges = 0;
        private int numberOfLocalPitScoutingChanges = 0;

        public DatabaseController()
        {
            rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CSP");
            Directory.CreateDirectory(rootFolderPath);
            infoFilePath = Path.Combine(rootFolderPath, "info.cfg");
            matchscoutingSavedPath = Path.Combine(rootFolderPath, "matchscouting.xml");

            matchscoutingDataTable = new CspAnalyzeDataSet.matchscoutingDataTable();
            matchscoutingTableAdapter = new CspAnalyzeDataSetTableAdapters.matchscoutingTableAdapter();

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

                    if (line.IndexOf("local_matchscouting_changes") >= 0)
                    {
                        numberOfLocalMatchScoutingChanges = int.Parse(line.Substring(line.IndexOf("=") + 1));
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
            File.WriteAllText(infoFilePath, "remote_last_updated=" + RemoteLastUpdated + "\nlocal_matchscouting_changes=" + numberOfLocalMatchScoutingChanges);
        }

        public int ImportMatchScoutingRows(LinkedList<string> matches)
        {
            DataColumnCollection columns = matchscoutingDataTable.Columns;

            foreach (string match in matches)
            {
                string[] values = match.Split(',');
                DataRow newMatch = matchscoutingDataTable.NewRow();

                // Add columns from match scouting
                for (int i = 1; i < values.Length; i++)
                {
                    string columnName = columns[i].ColumnName.ToString();
                    string value = values[i];
                    newMatch[columnName] = value;
                }

                // Add rows
                matchscoutingDataTable.Rows.Add(newMatch);
                numberOfLocalMatchScoutingChanges++;
            }

            SaveInfo();

            return numberOfLocalMatchScoutingChanges;
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

        public string RemotePull(Form1 form)
        {
            int results = matchscoutingTableAdapter.Fill(matchscoutingDataTable);

            try
            {
                matchscoutingDataTable.WriteXml(matchscoutingSavedPath);
            }
            catch (Exception e)
            {
                form.Log("An exception occurred while writing matchscouting xml: " + e.Message);
            }

            return string.Format("{0} rows affected by the pull.", results);
        }

        public string RemotePush()
        {


            return "TODO";
        }
    }
}
