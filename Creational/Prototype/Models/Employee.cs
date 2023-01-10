using System.Text.Json;

namespace Creational.Prototype.Models;

/// <summary>
/// Concrete Prototype
/// </summary>
public record Employee : Person, ICloneableGeneric<Employee>, IDeepClonable<Employee>
{
    public Manager Manager { get; set; }
    public override string Name { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }
    
    public Employee ShallowClone() => (Employee)MemberwiseClone();

    public Employee DeepClone()
    {
        var objectAsJson = JsonSerializer.Serialize(this);
            
        return JsonSerializer.Deserialize<Employee>(objectAsJson);
    }
}