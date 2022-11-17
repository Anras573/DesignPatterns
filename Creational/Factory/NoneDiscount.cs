namespace Creational.Factory;

/// <summary>
/// Concrete Product
/// </summary>
public record NoneDiscount() : ValueDiscount(0m);