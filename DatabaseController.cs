using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_Analyze
{
    class DatabaseController
    {
        public string CurrentQueryName;

        public static int MATCHSCOUTING_COLUMNS = 85;

        public const int SUCCESS = 0;
        public const int ERROR_INVALID_FILENAME = 1;
        public const int ERROR_FILE_ALREADY_EXISTS = 2;
        public const int ERROR_INVALID_PERMISSION = 3;

        public readonly string rootFolderPath;
        
        public DatabaseController()
        {
            rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CSP");
            Directory.CreateDirectory(rootFolderPath);
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
    }
}
