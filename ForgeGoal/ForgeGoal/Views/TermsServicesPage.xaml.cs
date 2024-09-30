namespace ForgeGoal.Views;

public partial class TermsServicesPage : ContentPage
{
	public TermsServicesPage()
	{
		InitializeComponent();
	}
	private async void OnAgreeClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("SignUpPage");
    }
}