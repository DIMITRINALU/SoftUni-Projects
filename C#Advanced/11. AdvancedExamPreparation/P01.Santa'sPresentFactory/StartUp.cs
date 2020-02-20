namespace P01.Santa_sPresentFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            const int DollMagicNeeded = 150;
            const int WoodenTrainMagicNeeded = 250;
            const int TeddyBearMagicNeeded = 300;
            const int BicycleMagicNeeded = 400;


            Stack<int> materials = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Queue<int> magics = new Queue<int>(Console.ReadLine()
               .Split()
               .Select(int.Parse));

            SortedDictionary<string, int> craftedPresents = new SortedDictionary<string, int>
            { { "Doll", 0 },
                { "Wooden train", 0 },
                { "Teddy bear", 0},
                {"Bicycle", 0}
            };

            while (materials.Count > 0 && magics.Count > 0)
            {
                int currentMaterial = materials.Peek();
                int currentMagic = magics.Peek();

                int totalMagicLevel = currentMaterial * currentMagic;

                switch (totalMagicLevel)
                {
                    case DollMagicNeeded:
                        craftedPresents["Doll"]++;
                        materials.Pop();
                        magics.Dequeue();
                        break;
                    case WoodenTrainMagicNeeded:
                        craftedPresents["Wooden train"]++;
                        materials.Pop();
                        magics.Dequeue();
                        break;
                    case TeddyBearMagicNeeded:
                        craftedPresents["Teddy bear"]++;
                        materials.Pop();
                        magics.Dequeue();
                        break;
                    case BicycleMagicNeeded:
                        craftedPresents["Bicycle"]++;
                        materials.Pop();
                        magics.Dequeue();
                        break;
                    default:
                        if (totalMagicLevel < 0)
                        {
                            var sum = currentMaterial + currentMagic;
                            materials.Pop();
                            magics.Dequeue();
                            materials.Push(sum);
                        }
                        else if (totalMagicLevel > 0)
                        {
                            materials.Push(materials.Pop() + 15);
                            magics.Dequeue();
                        }
                        else if (totalMagicLevel == 0)
                        {
                            if (materials.Peek() == 0)
                            {
                                materials.Pop();
                            }

                            if (magics.Peek() == 0)
                            {
                                magics.Dequeue();
                            }
                        }
                        break;
                }
            }

            Print(materials, magics, craftedPresents);
        }

        private static void Print(Stack<int> materials, Queue<int> magics, SortedDictionary<string, int> craftedPresents)
        {
            if (craftedPresents["Doll"] > 0 && craftedPresents["Wooden train"] > 0
                              || craftedPresents["Teddy bear"] > 0 && craftedPresents["Bicycle"] > 0)
            {
                Console.WriteLine($"The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");

            }

            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }

            if (magics.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magics)}");
            }

            foreach (var present in craftedPresents.Where(x => x.Value != 0))
            {
                Console.WriteLine($"{present.Key}: {present.Value}");
            }
        }
    }
}