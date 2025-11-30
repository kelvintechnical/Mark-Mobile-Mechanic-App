using MarkMobileMechanic.Core.DTOs;
using MarkMobileMechanic.Core.Interfaces;

namespace MarkMobileMechanic.Infrastructure.Services;

public class BookingConflictDetector : IBookingConflictDetector
{
    public bool HasConflict(IEnumerable<BookingDto> existingBookings, BookingDto proposedBooking)
    {
        return existingBookings.Any(existing =>
            existing.TechnicianId == proposedBooking.TechnicianId &&
            TimeRangesOverlap(existing.StartTime, existing.EndTime, proposedBooking.StartTime, proposedBooking.EndTime));
    }

    private static bool TimeRangesOverlap(DateTimeOffset startA, DateTimeOffset endA, DateTimeOffset startB, DateTimeOffset endB)
    {
        return startA < endB && startB < endA;
    }
}
