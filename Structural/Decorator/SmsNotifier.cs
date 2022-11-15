namespace Structural.Decorator;

public record SmsNotifier(INotifier InnerNotifier) : INotifier
{
    public void Send(string message)
    {
        InnerNotifier.Send(message);
        Console.WriteLine($"{nameof(SmsNotifier)}: {message}");
    }
}