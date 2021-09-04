using _01.Logger.Layout;

namespace _01.Logger.Factories
{
    public class LayoutFactory
    {
        public static ILayout CreateLayout(string layoutArgs)
        {
            ILayout layout = null;
            switch (layoutArgs)
            {
                case "SimpleLayout":
                    layout = new SimpleLayout();
                    break;
                case "XmlLayout":
                    layout = new XmlLayout();
                    break;
            }
            return layout;
        }
    }
}
