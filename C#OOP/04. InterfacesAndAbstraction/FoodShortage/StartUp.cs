namespace BorderControl
{
    using BorderControl.Contracts;
    using BorderControl.Models;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();

        }
    }
}