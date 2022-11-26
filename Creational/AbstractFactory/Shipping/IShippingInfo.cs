namespace Creational.AbstractFactory;

/// <summary>
/// AbstractProductB
/// </summary>
public interface IShippingInfo
{
    ShippingMethod ShippingMethod { get; }
    EstimatedDelivery EstimatedDelivery { get; }
    Price ShippingCost { get; }
}