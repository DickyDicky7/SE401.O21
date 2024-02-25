namespace AbstractFactory
{
    internal class Application
    {
        private IGUIFactory _guIFactory;
        private IButton _button1 = null!;
        private IButton _button2 = null!;
        private ICheckbox _checkbox1 = null!;

        public Application(IGUIFactory @gUIFactory)
        {
            _guIFactory = @gUIFactory;
        }

        public void CreateUI()
        {
            _button1 = _guIFactory.CreateButton();
            _button2 = _guIFactory.CreateButton();
            _checkbox1 = _guIFactory.CreateCheckbox();
        }

        public void Paint()
        {
            _button1.Paint();
            _button2.Paint();
            _checkbox1.Paint();
        }
    }
}
