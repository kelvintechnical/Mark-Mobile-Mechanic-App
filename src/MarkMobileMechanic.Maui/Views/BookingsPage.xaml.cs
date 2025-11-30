using MarkMobileMechanic.Maui.ViewModels;

namespace MarkMobileMechanic.Maui.Views;

public partial class BookingsPage : ContentPage
{
    public BookingsPage(BookingsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
