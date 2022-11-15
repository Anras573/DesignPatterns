using System.Diagnostics;

namespace Structural.Decorator;

public record TimeNotifier(INotifier InnerNotifier) : INotifier
{
    public void Send(string message)
    {
        var watch = Stopwatch.StartNew();
        InnerNotifier.Send(message);
        Console.WriteLine($"{nameof(TimeNotifier)}: Took {watch.Elapsed}");
    }
}