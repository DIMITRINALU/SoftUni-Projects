﻿namespace FootballTeamGenerator
{
    using FootballTeamGenerator.Core;    

    public class StartUp
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}