using Behavior.Command.Models;
using Common;

namespace Behavior.Command;

public class CommandRunner : IRunner
{
    public string Name => nameof(CommandRunner);
    public void Run()
    {
        var commandManager = new CommandManager();
        IEmployeeManagerRepository repository = new EmployeeManagerRepository();
        
        commandManager.Invoke(
            new AddEmployeeToManagerListCommand(repository, 1, new Employee(111, "Kevin")));
        repository.DumpToConsole();
        
        commandManager.Undo();
        repository.DumpToConsole();
        
        commandManager.Invoke(
            new AddEmployeeToManagerListCommand(repository, 1, new Employee(222, "Clara")));
        repository.DumpToConsole();
        
        commandManager.Invoke(
            new AddEmployeeToManagerListCommand(repository, 2, new Employee(333, "Tom")));
        repository.DumpToConsole();
        
        // Try adding Tom again.
        commandManager.Invoke(
            new AddEmployeeToManagerListCommand(repository, 2, new Employee(333, "Tom")));
        repository.DumpToConsole();
        
        // Undo all
        commandManager.UndoAll();
        repository.DumpToConsole();
    }
}