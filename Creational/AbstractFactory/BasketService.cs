namespace Creational.AbstractFactory;

/// <summary>
/// Concrete Creator / Concrete Abstract Factory
/// </summary>
public class BasketService : IBasketService
{
    private static readonly Dictionary<ShippingMethod, IShippingInfo> ShippingInfos =
        new()
        {
            { ShippingMethod.DAO, new ShippingInfo(ShippingMethod.DAO, new EstimatedDelivery(1, 2), new Price(4.5m)) },
            { ShippingMethod.GLS, new ShippingInfo(ShippingMethod.GLS, new EstimatedDelivery(1, 1), new Price(5m)) },
            { ShippingMethod.PostNord, new ShippingInfo(ShippingMethod.PostNord, new EstimatedDelivery(2, 3), new Price(6m)) }
        };
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="code"></param>
    /// <returns>AbstractProductA</returns>
    public IDiscount GetDiscount(DiscountCode code)
    {
        return code.Value switch
        {
            "BlackFriday25" => new PercentageDiscount(25m),
            "logbuy10" => new PercentageDiscount(10m),
            "SmartBuy15" => new ValueDiscount(15m),
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