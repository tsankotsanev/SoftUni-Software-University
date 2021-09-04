using _01.Raiding.Core;
using _01.Raiding.Core.Contacts;

namespace _01.Raiding
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
