using Creational.AbstractFactory;

namespace Creational.Factory;

/// <summary>
/// Creator
/// </summary>
public interface IDiscountFactory
{
    IDiscount GetDiscount(DiscountCode code);
}