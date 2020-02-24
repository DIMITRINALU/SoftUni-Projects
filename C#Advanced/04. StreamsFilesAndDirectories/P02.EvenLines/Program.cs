namespace P02.EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            using var reader = new StreamReader("text.txt");
            using var writer = new StreamWriter("result.txt");

            int counter = 0;
            var symbolsToReplace = new[] {"-", ",", ".", "!", "?"};

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if (counter % 2 == 0)
                {
                    var words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        var word = words[i];

                        foreach (var symbol in symbolsToReplace)
                        {
                            word = word.Replace(symbol, "@");
                        }

                        words[i] = word;
                    }

                    var result = string.Join(" ", words.Reverse());
                    writer.WriteLine(result);
                }

                counter++;
            }
        }
    }
}