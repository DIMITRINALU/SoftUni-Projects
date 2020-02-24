namespace P09.CopyBinaryFile
{
    using System.IO;

    class Program
    {
        static void Main()
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