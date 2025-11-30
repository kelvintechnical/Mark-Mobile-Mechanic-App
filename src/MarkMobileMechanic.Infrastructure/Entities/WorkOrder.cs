namespace MarkMobileMechanic.Infrastructure.Entities;

public class WorkOrder
{
    public Guid Id { get; set; }
    public Guid BookingId { get; set; }
    public string Notes { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
