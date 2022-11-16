namespace Creational.AbstractFactory;

/// <summary>
/// AbstractProductA
/// </summary>
public interface IDiscount
{
    string Type { get; }
    decimal Value { get; }
    
    Price Apply(Price subTotal);
}