using MarkMobileMechanic.Core.DTOs;
using MarkMobileMechanic.Infrastructure.Services;

namespace MarkMobileMechanic.Tests;

public class BookingConflictDetectorTests
{
    [Fact]
    public void HasConflict_ReturnsTrue_WhenTechnicianOverlaps()
    {
        // Arrange
        var detector = new BookingConflictDetector();
        var technicianId = Guid.NewGuid();
        var existing = new List<BookingDto>
        {
            new()
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.NewGuid(),
                TechnicianId = technicianId,
                StartTime = new DateTimeOffset(2024, 6, 1, 9, 0, 0, TimeSpan.Zero),
                EndTime = new DateTimeOffset(2024, 6, 1, 10, 0, 0, TimeSpan.Zero)
            }
        };

        var proposed = new BookingDto
        {
            Id = Guid.NewGuid(),
            CustomerId = Guid.NewGuid(),
            TechnicianId = technicianId,
            StartTime = new DateTimeOffset(2024, 6, 1, 9, 30, 0, TimeSpan.Zero),
            EndTime = new DateTimeOffset(2024, 6, 1, 10, 30, 0, TimeSpan.Zero)
        };

        // Act
        var hasConflict = detector.HasConflict(existing, proposed);

        // Assert
        Assert.True(hasConflict);
    }
}
