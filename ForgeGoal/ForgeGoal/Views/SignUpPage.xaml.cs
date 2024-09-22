namespace ForgeGoal.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	private void OnTermsAndServicesTapped(object sender, EventArgs e)
	{
		//TODO: ADD NAVIGATION TO SEND TO TERMS AND SERVICE VIEW
	}
	private async void OnLoginTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("LoginPage");

	}
}