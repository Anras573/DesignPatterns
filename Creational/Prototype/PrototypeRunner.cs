using Common;
using Creational.Prototype.Models;

namespace Creational.Prototype;

public class PrototypeRunner : IRunner
{
    public string Name => nameof(PrototypeRunner);
    public void Run()
    {
        var manager = new Manager("Cindy");
        Console.WriteLine($"Manager created: {manager}");
        
        Console.WriteLine();
        
        var managerClone = manager.ShallowClone();
        Console.WriteLine($"Manager was cloned : {managerClone.Name}");
        
        Console.WriteLine();
        
        var employee = new Employee("Kevin", managerClone);
        Console.WriteLine($"Employee created with the cloned manager: {employee}");
        
        Console.WriteLine();
        
        var employeeDeepClone = employee.DeepClone();
        Console.WriteLine($"Employee was deep cloned: {employeeDeepClone.Name}, with manager {employeeDeepClone.Manager.Name}");
        var employeeClone = employee.ShallowClone();
        Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");
        
        Console.WriteLine();

        managerClone.Name = "Karen";
        Console.WriteLine($"Changing the Cloned Manager's name: {managerClone.Name}");
        Console.WriteLine($"Cloned Employee: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");
        Console.WriteLine($"Deep Cloned Employee: {employeeDeepClone.Name}, with manager {employeeDeepClone.Manager.Name}");
    }
}