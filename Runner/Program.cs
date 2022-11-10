using Behavior.Strategy;
using Common;
using Structural.Decorator;

var runners = new List<IRunner>
{
    new DecoratorRunner(),
    new StrategyRunner()
};

var valid = false;
while (!valid)
{
    Console.WriteLine("Choose which example to run:");

    foreach((IRunner runner, int i) in runners.Select((runner, i) => (runner, i)))
    {
        Console.WriteLine($"{i} => {runner.Name}");
    }

    var choice = Console.ReadLine();

    valid = int.TryParse(choice, out var index) && index < runners.Count;
        
    if (!valid)
    {
        Console.Error.WriteLine("Invalid runner. Try again!");
        continue;
    }

    var example = runners.ElementAt(index);
    
    example.Run();
}

