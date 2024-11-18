using Pro10Prosper.MVVM.ViewModels;

namespace Pro10Prosper.MVVM.Views;

public partial class DashBoardPage : ContentPage
{
	public DashBoardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}

    private async void AddTransaction_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TransactionsPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (DashboardViewModel)BindingContext;
        vm.FillData();
    }
}