using MarkMobileMechanic.Maui.ViewModels;

namespace MarkMobileMechanic.Maui.Views;

public partial class VehiclesPage : ContentPage
{
    public VehiclesPage(VehiclesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
