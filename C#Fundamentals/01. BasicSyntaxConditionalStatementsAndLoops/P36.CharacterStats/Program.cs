namespace P36.CharacterStats
{
    using System;

    class Program
    {
        static void Main()
        {
            var characterName = Console.ReadLine();
            var characterHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var characterEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string healthBar = BuildStatBar(characterHealth, maxHealth);
            string energyBar = BuildStatBar(characterEnergy, maxEnergy);

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }

        public static string BuildStatBar(int statValue, int barMaxValue)
        {
            string statBar = "|" + new string('|', statValue) + new string('.', barMaxValue - statValue) + "|";
            return statBar;
        }
    }
}