using Common;

namespace Creational.AbstractFactory;

public class AbstractFactoryRunner : IRunner
{
    public string Name => nameof(AbstractFactoryRunner);
    
    public void Run()
    {
        var subTotal = new Price(250m);

        var discountCode = new DiscountCode("BlackFriday25");

        IBasketService abstractFactory = new BasketService();

        foreach (var shippingMethod in Enum.GetValues<ShippingMethod>())
        {
            Console.WriteLine($"Subtotal: {subTotal}");

            var shippingInfo = abstractFactory.GetShippingInfo(shippingMethod);
            
            Console.WriteLine($"Choosing shipping method: {shippingInfo}");

            var newSubTotal = new Price(shippingInfo.ShippingCost.Value + subTotal.Value);
            
            Console.WriteLine($"New subtotal: {newSubTotal}");

            Console.WriteLine($"Applying discount code: {discountCode}");
                
            var discount = abstractFactory.GetDiscount(discountCode);
                
            Console.WriteLine(discount);
                
            var discountValue = discount.Apply(newSubTotal);
                
            Console.WriteLine($"Discount value: {discountValue}");
            Console.WriteLine($"Total: {newSubTotal.Value - discountValue.Value}{Environment.NewLine}");
        }
    }
}