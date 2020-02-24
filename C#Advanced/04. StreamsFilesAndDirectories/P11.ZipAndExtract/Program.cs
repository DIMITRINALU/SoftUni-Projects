namespace P06.ZipAndExtract
{
    using System.IO.Compression;

    class Program
    {
        static void Main()
        {
            ZipFile.CreateFromDirectory(@"D:\SoftUni", @"C:\Users\owner\myArchive.zip");

            ZipFile.ExtractToDirectory(@"C:\Users\owner\myArchive.zip", @"C:\Users\owner");
        }
    }
}