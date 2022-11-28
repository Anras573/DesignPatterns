namespace Structural.Decorator;

public record NotifyCounterDecorator(INotifier InnerNotifier) : INotifier
{
    private static int _count = 0;
    
    public void Send(string message)
    {
        InnerNotifier.Send(message);
        _count++;
        Console.WriteLine($"{nameof(NotifyCounterDecorator)}: Number of notifications sent: {_count}");
    }
}