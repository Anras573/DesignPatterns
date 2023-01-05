using System.Text.Json;

namespace Creational.Prototype.Models;

/// <summary>
/// Concrete Prototype
/// </summary>
public class Employee : Person
{
    public Manager Manager { get; set; }
    public override string Name { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }
    
    public override Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var objectAsJson = JsonSerializer.Serialize(this);
            
            return JsonSerializer.Deserialize<Employee>(objectAsJson);
        }
        
        return (Person)MemberwiseClone();
    }
}