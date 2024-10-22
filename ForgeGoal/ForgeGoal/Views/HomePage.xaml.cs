using System.Diagnostics;

namespace ForgeGoal.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
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
	private async void OnUpdatesTapped(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//UpdatesPage");
    }
}