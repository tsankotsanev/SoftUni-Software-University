using _02.Vehicles.Core;

namespace _02.Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
