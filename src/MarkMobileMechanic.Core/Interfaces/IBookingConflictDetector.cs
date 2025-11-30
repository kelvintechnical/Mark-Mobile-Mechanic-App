using MarkMobileMechanic.Core.DTOs;

namespace MarkMobileMechanic.Core.Interfaces;

public interface IBookingConflictDetector
{
    bool HasConflict(IEnumerable<BookingDto> existingBookings, BookingDto proposedBooking);
}
