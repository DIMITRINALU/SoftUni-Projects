namespace Threeuple
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var personInfo = Console.ReadLine().Split();
            string fullName = personInfo[0] + " " +personInfo[1];
            string address = personInfo[2];
            string town = string.Join(" ", personInfo.Skip(3));

            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beer = int.Parse(nameAndBeer[1]);
            string type = nameAndBeer[2];
            bool isDrunk = type == "drunk" ? true : false;

            var bankBalance = Console.ReadLine().Split();
            string personName = bankBalance[0];            
            double account = double.Parse(bankBalance[1]);
            string bank = bankBalance[2];

            var firstTuple = new Threeuple<string, string, string>(fullName, address, town);
            var secondTuple = new Threeuple<string, int, bool>(name, beer, isDrunk);
            var thirdTuple = new Threeuple<string, double, string>(personName, account, bank);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}