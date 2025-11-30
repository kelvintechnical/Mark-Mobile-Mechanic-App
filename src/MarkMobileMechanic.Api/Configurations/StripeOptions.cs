namespace MarkMobileMechanic.Api.Configurations;

public class StripeOptions
{
    public const string SectionName = "Stripe";
    public string? SecretKey { get; init; }
}
