using System;
using System.IO;

namespace P04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new FileStream("copyMe.png", FileMode.Open);
            using var writer = new FileStream("copyMe-copy.png", FileMode.Create);
            
            while (true)
            {
                byte[] arr = new byte[4096];

                var size = reader.Read(arr, 0, arr.Length);

                if (size == 0)
                {
                    break;
                }

                writer.Write(arr, 0, size);
            }         
        }
    }
}