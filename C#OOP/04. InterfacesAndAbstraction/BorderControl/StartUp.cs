namespace BorderControl
{
    using BorderControl.Contracts;
    using BorderControl.Models;

    class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();

        }
    }
}