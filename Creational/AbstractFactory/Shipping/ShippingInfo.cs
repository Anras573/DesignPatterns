namespace Creational.AbstractFactory;

/// <summary>
/// ConcreteProductB
/// </summary>
/// <param name="ShippingMethod"></param>
/// <param name="EstimatedDelivery"></param>
/// <param name="ShippingCost"></param>
public record ShippingInfo
    (ShippingMethod ShippingMethod, EstimatedDelivery EstimatedDelivery, Price ShippingCost) : IShippingInfo;