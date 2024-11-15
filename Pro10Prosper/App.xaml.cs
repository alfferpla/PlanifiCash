using Pro10Prosper.MVVM.Views;

namespace Pro10Prosper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashBoardPage();
        }
    }
}
