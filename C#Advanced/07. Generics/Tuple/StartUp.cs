namespace Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = $"{personInfo[2]}";

            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beer = int.Parse(nameAndBeer[1]);

            var input = Console.ReadLine().Split();
            int firstArg = int.Parse(input[0]);
            double secondArg = double.Parse(input[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beer);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArg, secondArg);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}