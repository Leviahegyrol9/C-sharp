using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Git.Service
{
    public static class SettingsService
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

            return File.ReadAllLines(path).ToList();
        }

        public static void SavePath(string path)
        {
            File.WriteAllText(configPath, path);
        }
    }
}