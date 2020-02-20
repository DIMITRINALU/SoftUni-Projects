using System;
using System.IO;

namespace P06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(".");

            var totalLength = 0m;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                totalLength += fileInfo.Length;
            }

            totalLength = totalLength / 1024 / 1024;
            File.WriteAllText("output.txt", totalLength.ToString ());
        }
    }
}