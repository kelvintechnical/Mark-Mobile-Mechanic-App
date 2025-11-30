namespace MarkMobileMechanic.Core.DTOs;

public record BookingDto
{
    public Guid Id { get; init; }
    public Guid CustomerId { get; init; }
    public Guid TechnicianId { get; init; }
    public DateTimeOffset StartTime { get; init; }
    public DateTimeOffset EndTime { get; init; }
    public string Status { get; init; } = "Pending";
}
