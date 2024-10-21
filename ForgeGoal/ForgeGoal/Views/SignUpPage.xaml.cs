namespace ForgeGoal.Views;
using Firebase.Auth;


public partial class SignUpPage : ContentPage
{
    private readonly FirebaseAuthClient Client1;

    public SignUpPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    public SignUpPage(FirebaseAuthClient Client) 
	{ 
		Client1 = Client;
	}
	private async void OnTermsAndServicesTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("TermsServicesPage");
	}
	private async void OnLoginTapped(object sender, EventArgs e)	
	{
		await Shell.Current.GoToAsync("LoginPage");
	}
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("HomePage");
        Shell.Current.Navigation.RemovePage(this);
    }
}