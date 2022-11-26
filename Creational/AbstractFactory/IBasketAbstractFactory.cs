namespace Creational.AbstractFactory;

/// <summary>
/// Creator / AbstractFactory
/// </summary>
public interface IBasketAbstractFactory
{
    IDiscount GetDiscount(DiscountCode code, IShippingInfo shippingInfo);
    IShippingInfo GetShippingInfo(ShippingMethod shippingMethod);
}