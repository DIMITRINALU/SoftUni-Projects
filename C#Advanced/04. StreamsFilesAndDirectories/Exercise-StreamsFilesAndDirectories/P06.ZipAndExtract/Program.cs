using System;
using System.IO.Compression;

namespace P06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\SoftUni", @"C:\Users\owner\myArchive.zip");

            ZipFile.ExtractToDirectory(@"C:\Users\owner\myArchive.zip", @"C:\Users\owner");
        }
    }
}