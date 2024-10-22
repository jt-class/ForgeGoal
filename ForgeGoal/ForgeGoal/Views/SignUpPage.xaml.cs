namespace ForgeGoal.Views;
using Firebase.Auth;


public partial class SignUpPage : ContentPage
{

    public SignUpPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
	private async void OnTermsAndServicesTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("TermsServicesPage");
	}
	private async void OnLoginTapped(object sender, EventArgs e)	
	{
		await Shell.Current.GoToAsync("//LoginPage");
	}
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("HomePage");
        Shell.Current.Navigation.RemovePage(this);
    }
}