using Meterizer.ViewModels;

namespace Meterizer.Views;

public partial class MainPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}