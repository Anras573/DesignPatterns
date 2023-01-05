using Behavior.Command.Models;

namespace Behavior.Command;

/// <summary>
/// Receiver (implementation)
/// </summary>
public class EmployeeManagerRepository : IEmployeeManagerRepository
{
    private List<Manager> _managers = new()
    {
        new Manager(1, "Katie"),
        new Manager(2, "Geoff")
    };


    public void AddEmployee(int managerId, Employee employee)
    {
        _managers.First(m => m.Id == managerId).Employees.Add(employee);
    }

    public void RemoveEmployee(int managerId, Employee employee)
    {
        _managers.First(m => m.Id == managerId).Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, int employeeId)
    {
        return _managers.First(m => m.Id == managerId).Employees.Any(e => e.Id == employeeId);
    }

    /// <summary>
    /// For demo purposes, dump data to the console window.
    /// </summary>
    public void DumpToConsole()
    {
        foreach (var manager in _managers)
        {
            Console.WriteLine(manager);
            if (manager.Employees.Any())
            {
                foreach (var employee in manager.Employees)
                {
                    Console.WriteLine($"\t {employee}");
                }
            }
            else
            {
                Console.WriteLine("\t No employees.");
            }
        }
        
        Console.WriteLine();
    }
}