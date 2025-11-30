using MarkMobileMechanic.Core.DTOs;
using System.Collections.ObjectModel;

namespace MarkMobileMechanic.Maui.ViewModels;

public class BookingsViewModel : BaseViewModel
{
    public ObservableCollection<BookingDto> Bookings { get; } = new();

    public BookingsViewModel()
    {
        Bookings.Add(new BookingDto
        {
            Id = Guid.NewGuid(),
            CustomerId = Guid.NewGuid(),
            TechnicianId = Guid.NewGuid(),
            StartTime = DateTimeOffset.UtcNow.AddHours(2),
            EndTime = DateTimeOffset.UtcNow.AddHours(4),
            Status = "Scheduled"
        });
    }
}
