namespace ForgeGoal.Views;

public partial class TermsServicesPage : ContentPage
{
	public TermsServicesPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
	private async void OnAgreeClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignUpPage");
        Shell.Current.Navigation.RemovePage(this);
    }
}