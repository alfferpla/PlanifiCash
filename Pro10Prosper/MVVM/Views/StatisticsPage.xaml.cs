using Pro10Prosper.MVVM.ViewModels;

namespace Pro10Prosper.MVVM.Views;

public partial class StatisticsPage : ContentPage
{
	public StatisticsPage()
	{
		InitializeComponent();
		BindingContext = new StatisticsViewModel();
	}

    protected override void OnAppearing()
    {
        var vm = (StatisticsViewModel)BindingContext;
        vm.GetTransactionsSummary();
    }
}