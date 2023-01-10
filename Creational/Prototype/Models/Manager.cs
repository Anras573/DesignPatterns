using System.Text.Json;

namespace Creational.Prototype.Models;

/// <summary>
/// Concrete Prototype
/// </summary>
public record Manager : Person, IShallowCloneable<Manager>, IDeepClonable<Manager>
{
    public override string Name { get; set; }
    
    public Manager(string name)
    {
        Name = name;
    }

    public Manager ShallowClone() => (Manager)MemberwiseClone();

    public Manager DeepClone()
    {
        var objectAsJson = JsonSerializer.Serialize(this);
            
        return JsonSerializer.Deserialize<Manager>(objectAsJson);
    }
}