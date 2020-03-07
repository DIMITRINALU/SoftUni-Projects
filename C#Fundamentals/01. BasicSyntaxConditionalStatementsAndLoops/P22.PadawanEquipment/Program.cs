namespace P22.PadawanEquipment
{
    using System;

    class Program
    {
        static void Main()
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            decimal equipmentCost;

            if (studentsCount >= 6)
            {
                equipmentCost = lightsabersPrice * Math.Ceiling(studentsCount * 1.1m) + robesPrice * studentsCount + beltsPrice * (studentsCount / 6 * 5 + studentsCount % 6);
            }
            else
            {
                equipmentCost = lightsabersPrice * Math.Ceiling(studentsCount * 1.1m) + robesPrice * studentsCount + beltsPrice * studentsCount;
            }            
            
            if (equipmentCost <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(equipmentCost - amountOfMoney):f2}lv more.");
            }
        }
    }
}