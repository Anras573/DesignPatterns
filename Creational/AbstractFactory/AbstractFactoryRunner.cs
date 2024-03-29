﻿using Common;

namespace Creational.AbstractFactory;

public class AbstractFactoryRunner : IRunner
{
    public string Name => nameof(AbstractFactoryRunner);
    
    public void Run()
    {
        var subTotal = new Price(250m);
        
        IBasketAbstractFactory abstractFactory = new AmericanBasketAbstractFactory();
        var discountCode = new DiscountCode("BlackFriday25");
        var shippingMethods = new List<ShippingMethod>
        {
            ShippingMethod.Fedex,
            ShippingMethod.UPS,
            ShippingMethod.USPS
        };
        
        Console.WriteLine($"**** {nameof(AmericanBasketAbstractFactory)} ****{Environment.NewLine}");
        
        CalculatePrices(shippingMethods, subTotal, abstractFactory, discountCode);
        
        abstractFactory = new DanishBasketAbstractFactory();
        discountCode = new DiscountCode("logbuy10");
        shippingMethods = new List<ShippingMethod>
        {
            ShippingMethod.PostNord,
            ShippingMethod.DAO,
            ShippingMethod.GLS
        };
        
        Console.WriteLine($"**** {nameof(DanishBasketAbstractFactory)} ****{Environment.NewLine}");
        
        CalculatePrices(shippingMethods, subTotal, abstractFactory, discountCode);
    }

    private static void CalculatePrices(
        List<ShippingMethod> shippingMethods,
        Price subTotal,
        IBasketAbstractFactory abstractFactory,
        DiscountCode discountCode)
    {
        foreach (var shippingMethod in shippingMethods)
        {
            Console.WriteLine($"Subtotal: {subTotal}");

            var shippingInfo = abstractFactory.GetShippingInfo(shippingMethod);

            Console.WriteLine($"Choosing shipping method: {shippingInfo}");

            var newSubTotal = new Price(shippingInfo.ShippingCost.Value + subTotal.Value);

            Console.WriteLine($"New subtotal: {newSubTotal}");

            Console.WriteLine($"Applying discount code: {discountCode}");

            var discount = abstractFactory.GetDiscount(discountCode, shippingInfo);

            Console.WriteLine(discount);

            var discountValue = discount.Apply(newSubTotal);

            Console.WriteLine($"Discount value: {discountValue}");
            Console.WriteLine($"Total: {newSubTotal.Value - discountValue.Value}{Environment.NewLine}");
        }
    }
}