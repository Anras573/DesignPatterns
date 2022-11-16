namespace Creational.Factory;

/// <summary>
/// Creator
/// </summary>
public interface IDiscountService
{
    IDiscount GetDiscount(DiscountCode code);
}