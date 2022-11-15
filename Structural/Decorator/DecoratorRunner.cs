using Common;

namespace Structural.Decorator;

public record DecoratorRunner : IRunner
{
    public string Name => nameof(DecoratorRunner);

    public void Run()
    {
        INotifier notifier = new Notifier();
        notifier = new SmsNotifier(notifier);
        notifier = new TimeNotifier(notifier);
        // Same as: var notifier = new TimeNotifier(new SmsNotifier(new Notifier()));

        notifier.Send("Hello World!");
    }
}