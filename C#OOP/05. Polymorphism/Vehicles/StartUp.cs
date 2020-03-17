namespace Vehicles
{   
    using Vehicles.Core;
    using Vehicles.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}