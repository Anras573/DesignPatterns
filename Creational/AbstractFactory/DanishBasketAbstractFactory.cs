namespace Creational.AbstractFactory;

/// <summary>
/// Concrete Creator / Concrete Abstract Factory
/// </summary>
public class DanishBasketAbstractFactory : IBasketAbstractFactory
{
    private static readonly Dictionary<ShippingMethod, IShippingInfo> ShippingInfos =
        new()
        {
            { ShippingMethod.DAO, new ShippingInfo(ShippingMethod.DAO, new EstimatedDelivery(1, 2), new Price(40m)) },
            { ShippingMethod.GLS, new ShippingInfo(ShippingMethod.GLS, new EstimatedDelivery(1, 1), new Price(50m)) },
            { ShippingMethod.PostNord, new ShippingInfo(ShippingMethod.PostNord, new EstimatedDelivery(2, 3), new Price(60m)) }
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
            "logbuy10" => new PercentageDiscount(10m),
            "SmartBuy15" => new ValueDiscount(15m),
            "GratisFragt" => new ValueDiscount(shippingInfo.ShippingCost.Value),
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