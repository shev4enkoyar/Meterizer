using Meterizer.Views;

namespace Meterizer;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(Routes.InitialPage, typeof(InitialPage));
        Routing.RegisterRoute(Routes.SettingsPage, typeof(SettingsPage));
    }
}