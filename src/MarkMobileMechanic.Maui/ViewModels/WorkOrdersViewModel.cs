using MarkMobileMechanic.Core.DTOs;
using System.Collections.ObjectModel;

namespace MarkMobileMechanic.Maui.ViewModels;

public class WorkOrdersViewModel : BaseViewModel
{
    public ObservableCollection<WorkOrderDto> WorkOrders { get; } = new(
        new[]
        {
            new WorkOrderDto { Id = Guid.NewGuid(), BookingId = Guid.NewGuid(), Notes = "Inspect suspension", IsCompleted = false }
        });
}
