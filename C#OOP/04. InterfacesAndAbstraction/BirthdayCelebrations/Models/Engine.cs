namespace BorderControl.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using BorderControl.Contracts;

    public class Engine : IEngine
    {
        private readonly List<IExistable> born;

        public Engine()
        {
           this.born = new List<IExistable>();
        }

        public void Run()
        {   
            string information = Console.ReadLine();

            while (information != "End")
            {
                var infoArgs = information.Split();

                if (infoArgs[0] == "Citizen")
                {
                    born.Add(new Citizen(infoArgs[1], int.Parse(infoArgs[2]), infoArgs[3], infoArgs[4]));
                }
                else if (infoArgs[0] == "Pet")
                {
                    born.Add(new Pet(infoArgs[1], infoArgs[2]));
                }

                information = Console.ReadLine();
            }

            string year = Console.ReadLine();

            var bornInYear = born
                .Where(x => x.BirthDate.Split('/').Last() == year);

            foreach (var born in bornInYear)
            {
                Console.WriteLine(born.BirthDate);
            }
        }
    }
}