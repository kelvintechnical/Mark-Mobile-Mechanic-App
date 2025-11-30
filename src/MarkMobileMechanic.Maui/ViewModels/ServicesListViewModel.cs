using MarkMobileMechanic.Core.DTOs;
using System.Collections.ObjectModel;

namespace MarkMobileMechanic.Maui.ViewModels;

public class ServicesListViewModel : BaseViewModel
{
    public ObservableCollection<ServiceDto> Services { get; } = new(
        new[]
        {
            new ServiceDto { Id = Guid.NewGuid(), Name = "Oil Change", Description = "Premium synthetic oil", Price = 89.99m },
            new ServiceDto { Id = Guid.NewGuid(), Name = "Brake Inspection", Description = "Full inspection", Price = 59.99m }
        });
}
