namespace Creational.Factory;

/// <summary>
/// Our Concrete Product
/// </summary>
/// <param name="Value"></param>
public record ValueDiscount(decimal Value) : IDiscount
{
    public string Type => nameof(ValueDiscount);

    public Price Apply(Price subTotal)
    {
        return new Price(Value);
    }
}