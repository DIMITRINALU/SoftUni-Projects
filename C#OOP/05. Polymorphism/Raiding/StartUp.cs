namespace Raiding
{
    using Raiding.Core;
    using Raiding.Core.Contracts;
    using Raiding.IO;
    using Raiding.IO.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}