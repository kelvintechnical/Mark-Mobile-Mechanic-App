using MarkMobileMechanic.Maui.ViewModels;

namespace MarkMobileMechanic.Maui.Views;

public partial class WorkOrdersPage : ContentPage
{
    public WorkOrdersPage(WorkOrdersViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
