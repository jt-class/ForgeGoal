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
        }
    }
}
