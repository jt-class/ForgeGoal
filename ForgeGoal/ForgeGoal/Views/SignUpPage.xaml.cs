namespace ForgeGoal.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	private async void OnTermsAndServicesTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("TermsServicesPage");
	}
	private async void OnLoginTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("LoginPage");

	}
}