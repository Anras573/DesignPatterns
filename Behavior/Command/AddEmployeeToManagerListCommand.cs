using Behavior.Command.Models;

namespace Behavior.Command;

/// <summary>
/// Concrete Command
/// </summary>
public class AddEmployeeToManagerListCommand : ICommand
{
    private readonly IEmployeeManagerRepository _employeeManagerRepository;
    private readonly int _managerId;
    private readonly Employee? _employee;

    public AddEmployeeToManagerListCommand(
        IEmployeeManagerRepository employeeManagerRepository,
        int managerId,
        Employee? employee)
    {
        _employeeManagerRepository = employeeManagerRepository;
        _managerId = managerId;
        _employee = employee;
    }
    
    public void Execute()
    {
        if (_employee is null) return;
        
        _employeeManagerRepository.AddEmployee(_managerId, _employee);
    }

    public bool CanExecute()
    {
        if (_employee is null)
            return false;
        
        if (_employeeManagerRepository.HasEmployee(_managerId, _employee.Id))
            return false;

        return true;
    }

    public void Undo()
    {
        if (_employee is null) return;
        
        _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
    }
}