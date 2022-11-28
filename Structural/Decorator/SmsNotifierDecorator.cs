namespace Structural.Decorator;

public record SmsNotifierDecorator(INotifier InnerNotifier) : INotifier
{
    public void Send(string message)
    {
        InnerNotifier.Send(message);
        Console.WriteLine($"{nameof(SmsNotifierDecorator)}: {message}");
    }
}