namespace Creational.Factory;

/// <summary>
/// Our Product
/// </summary>
public interface IDiscount
{
    string Type { get; }
    decimal Value { get; }
    
    Price Apply(Price subTotal);
}