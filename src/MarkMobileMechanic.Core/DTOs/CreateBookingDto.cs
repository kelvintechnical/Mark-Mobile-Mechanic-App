namespace MarkMobileMechanic.Core.DTOs;

public record CreateBookingDto
{
    public Guid CustomerId { get; init; }
    public Guid TechnicianId { get; init; }
    public DateTimeOffset StartTime { get; init; }
    public DateTimeOffset EndTime { get; init; }
}
