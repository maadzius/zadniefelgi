namespace Felgi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            

          //  MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)

        {

            var window = new Window();

            window.MaximumHeight = 800;

            window.MaximumWidth = 500;

            window.MinimumHeight = 800;

            window.MinimumWidth = 500;

            window.Page = new AppShell();

            return window;

        }


    }
}
