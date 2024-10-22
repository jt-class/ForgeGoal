namespace ForgeGoal.Views;

public partial class UpdatesPage : ContentPage
{
	public UpdatesPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    private void OnHamburgerClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
    }

    private async void OnCalendarTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CalendarPage");
    }
    private async void OnHomeTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }
}