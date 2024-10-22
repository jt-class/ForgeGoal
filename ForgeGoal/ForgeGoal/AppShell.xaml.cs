using ForgeGoal.Views;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace ForgeGoal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(TermsServicesPage), typeof(TermsServicesPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(UpdatesPage), typeof(UpdatesPage));
            Routing.RegisterRoute(nameof(CalendarPage), typeof(CalendarPage));
        }
        private async void OnDashboardTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
            Shell.Current.FlyoutIsPresented = false;

        }
    }
}
