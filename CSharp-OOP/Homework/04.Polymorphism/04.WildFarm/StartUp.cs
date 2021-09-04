using _04.WildFarm.Core;
using _04.WildFarm.Core.Contract;

namespace _04.WildFarm
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
