namespace PlayersAndMonsters
{
    using PlayersAndMonsters.Elfs;
    using PlayersAndMonsters.Knights;
    using PlayersAndMonsters.Wizards;

    public class StartUp
    {
        public static void Main()
        {
            MuseElf elf = new MuseElf("Elf", 300);
            DarkKnight knight = new DarkKnight("Knight", 500);
            SoulMaster wizard = new SoulMaster("Wizard", 800);

            System.Console.WriteLine(elf);
            System.Console.WriteLine(knight);
            System.Console.WriteLine(wizard);
        }
    }
}