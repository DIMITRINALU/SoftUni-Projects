namespace P43.WordInPlural
{
    using System;

    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            bool isEndingY = word.EndsWith("y");
            bool isEnd_o_ch_s_sh_x_z = word.EndsWith("o") ||
                                       word.EndsWith("ch") ||
                                       word.EndsWith("s") ||
                                       word.EndsWith("sh") ||
                                       word.EndsWith("x") ||
                                       word.EndsWith("z");
            if (isEnd_o_ch_s_sh_x_z)
            {
                word += "es";
            }
            else if (isEndingY)
            {
                word = word.Remove(word.Length - 1) + "ies";
            }
            else
            {
                word += "s";
            }


            Console.WriteLine(word);
        }
    }
}