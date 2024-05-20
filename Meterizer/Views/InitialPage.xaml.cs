using Meterizer.ViewModels;

namespace Meterizer.Views;

public partial class InitialPage
{
    public InitialPage(InitialPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}