namespace Behavior.Command.Models;

public record Manager(int Id, string Name) : Employee(Id, Name)
{
    public readonly List<Employee> Employees = new();
}