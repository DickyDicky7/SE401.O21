namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] @args)
        {
            Application application = new(Configurator.GetGUIFactory());
            application.CreateUI();
            application.Paint();
        }
    }
}
