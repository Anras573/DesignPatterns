namespace Creational.Factory;

/// <summary>
/// Our Concrete Product
/// </summary>
public record NoneDiscount() : ValueDiscount(0m);