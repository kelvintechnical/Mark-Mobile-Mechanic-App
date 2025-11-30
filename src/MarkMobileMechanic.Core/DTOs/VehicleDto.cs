namespace MarkMobileMechanic.Core.DTOs;

public record VehicleDto
{
    public Guid Id { get; init; }
    public Guid CustomerId { get; init; }
    public string Make { get; init; } = string.Empty;
    public string Model { get; init; } = string.Empty;
    public int Year { get; init; }
    public string Vin { get; init; } = string.Empty;
}
