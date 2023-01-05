using Common;
using Creational.Prototype.Models;

namespace Creational.Prototype;

public class PrototypeRunner : IRunner
{
    public string Name => nameof(PrototypeRunner);
    public void Run()
    {
        var manager = new Manager("Cindy");
        var managerClone = (Manager)manager.Clone();
        Console.WriteLine($"Manager was cloned : {managerClone.Name}");
        
        var employee = new Employee("Kevin", managerClone);
        var employeeClone = (Employee)employee.Clone(true);
        Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

        managerClone.Name = "Karen";
        Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");
    }
}