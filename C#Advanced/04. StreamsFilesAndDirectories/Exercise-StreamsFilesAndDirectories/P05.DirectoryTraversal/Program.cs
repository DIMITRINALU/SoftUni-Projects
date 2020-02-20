using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {     
            var filesInDir = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo dirInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = dirInfo.GetFiles();

            foreach (FileInfo file in allFiles)
            {
                double size = file.Length / 1024d;
                string name = file.Name;
                string extension = file.Extension;

                if (!filesInDir.ContainsKey(extension))
                {
                    filesInDir.Add(extension, new Dictionary<string, double>());
                }

                if (!filesInDir[extension].ContainsKey(name))
                {
                    filesInDir[extension].Add(name, size);
                }
            }

            string reportPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";
            
            foreach (var (extension, value) in filesInDir.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                File.AppendAllText(reportPath, extension + Environment.NewLine);

                foreach (var (name, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(reportPath, $"--{name} - {Math.Round(size, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}