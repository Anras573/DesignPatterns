namespace Structural.Decorator;

public record Notifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"{nameof(Notifier)}: {message}");
    }
}