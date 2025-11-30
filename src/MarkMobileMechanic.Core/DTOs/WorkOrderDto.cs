namespace MarkMobileMechanic.Core.DTOs;

public record WorkOrderDto
{
    public Guid Id { get; init; }
    public Guid BookingId { get; init; }
    public string Notes { get; init; } = string.Empty;
    public bool IsCompleted { get; init; }
}
