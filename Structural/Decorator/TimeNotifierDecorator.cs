using System.Diagnostics;

namespace Structural.Decorator;

public record TimeNotifierDecorator(INotifier InnerNotifier) : INotifier
{
    public void Send(string message)
    {
        var watch = Stopwatch.StartNew();
        InnerNotifier.Send(message);
        Console.WriteLine($"{nameof(TimeNotifierDecorator)}: Took {watch.Elapsed}");
    }
}