using MarkMobileMechanic.Maui.ViewModels;

namespace MarkMobileMechanic.Maui.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
