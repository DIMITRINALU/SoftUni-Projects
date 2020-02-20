using System;
using System.Linq;

namespace P06.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = new Action<string>((name) =>
            {
                Console.WriteLine(name);
            });

            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printName);

            //Action<string[]> printName = new Action<string[]>((name) =>
            //{
            //    Console.WriteLine(string.Join(Envoirment.NewLine, name);
            //});

            //string[] names = Console.ReadLine().Split();
        }
    }
}