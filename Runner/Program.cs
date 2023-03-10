using Behavior.ChainOfResponsibility;
using Behavior.Command;
using Behavior.Interpreter;
using Behavior.Mediator;
using Behavior.Strategy;
using Behavior.Visitor;
using Common;
using Creational.AbstractFactory;
using Creational.Factory;
using Creational.Prototype;
using Structural.Decorator;

var runners = new List<IRunner>
{
    new DecoratorRunner(),
    new StrategyRunner(),
    new FactoryRunner(),
    new AbstractFactoryRunner(),
    new OpenClosedChainOfResponsibilityRunner(),
    new ShortCircuitChainOfResponsibilityRunner(),
    new PrototypeRunner(),
    new CommandRunner(),
    new VisitorRunner(),
    new MediatorRunner(),
    new OnlyTerminalInterpreterRunner(),
    new FullInterpreterRunner()
};

var keepGoing = true;

while (keepGoing)
{
    Console.WriteLine("Choose option to run, or enter 'exit' to exit program.");

    foreach(var (runner, i) in runners.Select((runner, i) => (runner, i)))
    {
        var prepend = i < 10 ? " " : string.Empty;
        Console.WriteLine($"{prepend}{i} => {runner.Name}");
    }

    var input = Console.ReadLine();
    
    Console.WriteLine();
    
    if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
    {
        keepGoing = false;
    }
    else if (int.TryParse(input, out var index))
    {
        var example = runners.ElementAtOrDefault(index);
    
        example?.Run();
    }
    
    Console.WriteLine();
}
