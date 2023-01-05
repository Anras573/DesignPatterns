using System.Text.Json;
using System.Text.Json.Serialization;

namespace Creational.Prototype.Models;

/// <summary>
/// Concrete Prototype
/// </summary>
public class Manager : Person
{
    public override string Name { get; set; }
    
    public Manager(string name)
    {
        Name = name;
    }
    
    public override Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var objectAsJson = JsonSerializer.Serialize(this);
            
            return JsonSerializer.Deserialize<Manager>(objectAsJson);
        }
        
        return (Person)MemberwiseClone();
    }
}