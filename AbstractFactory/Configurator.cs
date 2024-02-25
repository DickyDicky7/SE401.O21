namespace AbstractFactory
{
    internal static class Configurator
    {
        private static string OS = "Win";
        private static Dictionary<string, IGUIFactory> IGUIFactories = new()
        {
            { "Win", new WinFactory() },
            { "Mac", new MacFactory() },
        };

        public static IGUIFactory GetGUIFactory()
        {
            return IGUIFactories[OS];
        }
    }
}
