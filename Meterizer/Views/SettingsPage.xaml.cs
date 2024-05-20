using Meterizer.ViewModels;

namespace Meterizer.Views;

public partial class SettingsPage
{
    public SettingsPage(SettingsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}