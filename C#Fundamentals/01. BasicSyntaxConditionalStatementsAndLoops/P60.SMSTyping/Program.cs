namespace P60.SMSTyping
{
    using System;

    class Program
    {
        static void Main()
        {
            string[][] smsTable = new string[][]
            {
                new string[]{" "},
                new string[]{ },
                new string[]{"a", "b","c"},
                new string[]{"d","e","f"},
                new string[]{"g","h","i"},
                new string[]{"j","k","l" },
                new string[]{"m","n","o"},
                new string[]{"p","q","r","s"},
                new string[]{"t","u","v" },
                new string[]{"w","x","y","z" }
            };

            int characterCount = int.Parse(Console.ReadLine());
            string outputSms = "";

            for (int i = 0; i < characterCount; i++)
            {
                int charCode = int.Parse(Console.ReadLine());
                outputSms += smsTable[charCode % 10][charCode.ToString().Length - 1];
            }

            Console.WriteLine(outputSms);
        }
    }
}