namespace BorderControl.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using BorderControl.Contracts;

    public class Engine : IEngine
    {
        private readonly List<IIdentifyable> identifyables;

        public Engine()
        {
           this.identifyables = new List<IIdentifyable>();
        }

        public void Run()
        {   
            string information = Console.ReadLine();

            while (information != "End")
            {
                var infoArgs = information.Split();

                if (infoArgs.Length == 3)
                {
                    identifyables.Add(new Citizen(infoArgs[0], int.Parse(infoArgs[1]), infoArgs[2]));
                }
                else if (infoArgs.Length == 2)
                {
                    identifyables.Add(new Robot(infoArgs[0], infoArgs[1]));
                }

                information = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();

            var fakeIndividuals = identifyables.Where(x => x.Id.EndsWith(fakeId));

            foreach (var fakeIndividual in fakeIndividuals)
            {
                Console.WriteLine(fakeIndividual.Id);
            }
        }
    }
}