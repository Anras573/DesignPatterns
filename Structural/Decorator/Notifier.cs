using System.Diagnostics;
using Common;

namespace Structural.Decorator;

public interface INotifier
{
    void Send(string message);
}

public record Notifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"{nameof(Notifier)}: {message}");
    }
}

public record SmsNotifier(INotifier InnerNotifier) : INotifier
{
    public void Send(string message)
    {
        InnerNotifier.Send(message);
        Console.WriteLine($"{nameof(SmsNotifier)}: {message}");
    }
}

public record TimeNotifier(INotifier InnerNotifier) : INotifier
{
    public void Send(string message)
    {
        var watch = Stopwatch.StartNew();
        InnerNotifier.Send(message);
        Console.WriteLine($"{nameof(TimeNotifier)}: Took {watch.Elapsed}");
    }
}

public record DecoratorRunner : IRunner
{
    public string Name => nameof(DecoratorRunner);

    public void Run()
    {
        INotifier notifier = new Notifier();
        notifier = new SmsNotifier(notifier);
        notifier = new TimeNotifier(notifier);

        notifier.Send("Hello World!");
    }
}