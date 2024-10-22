namespace ForgeGoal.Views;

public partial class CalendarPage : ContentPage
{
	public CalendarPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    private void OnHamburgerClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
    }

    private async void OnUpdatesTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("UpdatesPage");
    }
    private async void OnHomeTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("HomePage");
    }
}