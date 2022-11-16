namespace Creational.Factory;

/// <summary>
/// Our Concrete Product
/// </summary>
/// <param name="Value"></param>
public record PercentageDiscount(decimal Value) : IDiscount
{
    public string Type => nameof(PercentageDiscount);

    public Price Apply(Price subTotal)
    {
        return new Price(subTotal.Value * (Value / 100m));
    }
}