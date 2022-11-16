using Common;

namespace Creational.Factory;

public class FactoryRunner : IRunner
{
    public string Name => nameof(FactoryRunner);
    public void Run()
    {
        var subTotal = new Price(250m);

        var discountCodes = new List<DiscountCode>
        {
            new ("BlackFriday25"),
            new ("logbuy10"),
            new ("SmartBuy15"),
            new ("NovemberDeals")
        };

        IDiscountService factory = new DiscountService();
        
        foreach (var discountCode in discountCodes)
        {
            Console.WriteLine($"Subtotal: {subTotal}");
            Console.WriteLine($"Applying discount code: {discountCode}");
            
            var discount = factory.GetDiscount(discountCode);
            
            Console.WriteLine(discount);
            
            var discountValue = discount.Apply(subTotal);
            
            Console.WriteLine($"Discount value: {discountValue}");
            Console.WriteLine($"Total: {subTotal.Value - discountValue.Value}{Environment.NewLine}");
        }
    }
}
