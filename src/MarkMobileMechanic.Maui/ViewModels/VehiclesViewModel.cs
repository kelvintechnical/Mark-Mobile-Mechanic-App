using MarkMobileMechanic.Core.DTOs;
using System.Collections.ObjectModel;

namespace MarkMobileMechanic.Maui.ViewModels;

public class VehiclesViewModel : BaseViewModel
{
    public ObservableCollection<VehicleDto> Vehicles { get; } = new(
        new[]
        {
            new VehicleDto { Id = Guid.NewGuid(), CustomerId = Guid.NewGuid(), Make = "Toyota", Model = "Rav4", Year = 2022, Vin = "ABC123" }
        });
}
