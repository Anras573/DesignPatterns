namespace Creational.AbstractFactory;

/// <summary>
/// Creator / AbstractFactory
/// </summary>
public interface IBasketService
{
    IDiscount GetDiscount(DiscountCode code);
    IShippingInfo GetShippingInfo(ShippingMethod shippingMethod);
}