namespace Creational.Factory;

/// <summary>
/// Concrete Creator
/// </summary>
public class DiscountService : IDiscountService
{
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
}