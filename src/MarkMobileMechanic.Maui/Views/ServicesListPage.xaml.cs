using MarkMobileMechanic.Maui.ViewModels;

namespace MarkMobileMechanic.Maui.Views;

public partial class ServicesListPage : ContentPage
{
    public ServicesListPage(ServicesListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
