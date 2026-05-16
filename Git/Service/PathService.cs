using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Git.Service
{
    public static class PathService
    {
        public static string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        public static string configPath = Path.Combine(userProfile, "gitDirsPath.txt");

        public static bool HasValidConfig()
        {
            if (!File.Exists(configPath)) return false;

            string path = File.ReadAllText(configPath);

            return !string.IsNullOrWhiteSpace(path) && File.Exists(path);
        }
        public static List<string> GetPaths()
        {
            string path = File.ReadAllText(configPath);

            return File.ReadAllLines(path).Where(IsValidDirectory).ToList();
        }
        private static bool IsValidDirectory(string dir)
        {
            if (string.IsNullOrWhiteSpace(dir))
                return false;

            try
            {
                string fullPath = Path.GetFullPath(dir);

                bool valid =
                    fullPath.Length >= 3 &&
                    char.IsLetter(fullPath[0]) &&
                    fullPath[1] == ':' &&
                    (fullPath[2] == '\\' || fullPath[2] == '/');

                if (!valid)
                    return false;

                if (!Directory.Exists(fullPath))
                    return false;

                if (!Directory.Exists(Path.Combine(fullPath, ".git")))
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void SavePath(string path)
        {
            File.WriteAllText(configPath, path);
        }
    }
}