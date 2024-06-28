using PrimeraMauiApp.Pages;

namespace PrimeraMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InicioPage();
        }
    }
}
