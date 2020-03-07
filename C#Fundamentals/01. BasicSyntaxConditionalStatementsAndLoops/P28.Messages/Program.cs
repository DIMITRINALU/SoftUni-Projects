namespace P28.Messages
{
    using System;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string symbol = "";
            int counter = 1;            
            string text = "";

            while (counter <= input)
            {
                int number = int.Parse(Console.ReadLine());                

                switch (number)
                {
                    case 0: symbol = " "; break;
                    case 2: symbol = "a"; break;
                    case 22: symbol = "b"; break;
                    case 222: symbol = "c"; break;
                    case 3: symbol = "d"; break;
                    case 33: symbol = "e"; break;
                    case 333: symbol = "f"; break;
                    case 4: symbol = "g"; break;
                    case 44: symbol = "h"; break;
                    case 444: symbol = "i"; break;
                    case 5: symbol = "j"; break;
                    case 55: symbol = "k"; break;
                    case 555: symbol = "l"; break;
                    case 6: symbol = "m"; break;
                    case 66: symbol = "n"; break;
                    case 666: symbol = "o"; break;
                    case 7: symbol = "p"; break;
                    case 77: symbol = "q"; break;
                    case 777: symbol = "r"; break;
                    case 7777: symbol = "s"; break;
                    case 8: symbol = "t"; break;
                    case 88: symbol = "u"; break;
                    case 888: symbol = "v"; break;
                    case 9: symbol = "w"; break;
                    case 99: symbol = "x"; break;
                    case 999: symbol = "y"; break;
                    case 9999: symbol = "z"; break;
                }

                text += symbol;
                counter++;
            }

            Console.WriteLine(text);
        }
    }
}