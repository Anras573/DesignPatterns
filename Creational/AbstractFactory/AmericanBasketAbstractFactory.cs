namespace Creational.AbstractFactory;

/// <summary>
/// Concrete Creator / Concrete Abstract Factory
/// </summary>
public class AmericanBasketAbstractFactory : IBasketAbstractFactory
{
    private static readonly Dictionary<ShippingMethod, IShippingInfo> ShippingInfos =
        new()
        {
            { ShippingMethod.Fedex, new ShippingInfo(ShippingMethod.Fedex, new EstimatedDelivery(1, 2), new Price(4.5m)) },
            { ShippingMethod.UPS, new ShippingInfo(ShippingMethod.UPS, new EstimatedDelivery(1, 1), new Price(5m)) },
            { ShippingMethod.USPS, new ShippingInfo(ShippingMethod.USPS, new EstimatedDelivery(2, 3), new Price(6m)) }
        };
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="code"></param>
    /// <param name="shippingInfo"></param>
    /// <returns>AbstractProductA</returns>
    public IDiscount GetDiscount(DiscountCode code, IShippingInfo shippingInfo)
    {
        return code.Value switch
        {
            "BlackFriday25" => new PercentageDiscount(25m),
            "SmartBuy15" => new ValueDiscount(15m),
            "FreeShipping" => new ValueDiscount(shippingInfo.ShippingCost.Value),
            _ => new NoneDiscount()
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="shippingMethod"></param>
    /// <returns>AbstractProductB</returns>
    public IShippingInfo GetShippingInfo(ShippingMethod shippingMethod)
    {
        return ShippingInfos[shippingMethod];
    }
}