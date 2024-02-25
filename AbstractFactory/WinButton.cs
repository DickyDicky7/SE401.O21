namespace AbstractFactory
{
    internal class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Paint WinButton");
        }
    }
}
