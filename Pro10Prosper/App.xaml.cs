using Pro10Prosper.MVVM.Models;
using Pro10Prosper.MVVM.Views;
using Pro10Prosper.Repositories;


namespace Pro10Prosper
{
    public partial class App : Application
    {

        public static BaseRepository<Transaction>
            TransactionsRepo{get;private set;}
        public App(BaseRepository<Transaction>_transcationsRepo)
        {
            InitializeComponent();

            TransactionsRepo = _transcationsRepo;

            MainPage = new AppContainer();
        }
    }
}
