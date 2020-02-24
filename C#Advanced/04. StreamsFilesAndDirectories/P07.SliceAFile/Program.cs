namespace P07.SliceAFile
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            using var stream = new FileStream("sliceMe.txt", FileMode.OpenOrCreate);

            var parts = 4;

            var length = (int)Math.Ceiling(stream.Length / (decimal)parts);

            var buffer = new byte[length];

            for (int i = 0; i < parts; i++)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesRead)
                        .ToArray();
                }

                using var currentPartStream = new FileStream($"Part-{i + 1}.txt", FileMode.OpenOrCreate);

                currentPartStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}