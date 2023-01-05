namespace Creational.Prototype.Models;

/// <summary>
/// Prototype
/// </summary>
public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract Person Clone(bool deepClone);
}