using Common;

namespace Structural.Decorator;

public record DecoratorRunner : IRunner
{
    public string Name => nameof(DecoratorRunner);

    public void Run()
    {
        INotifier notifier = new Notifier();
        notifier = new SmsNotifierDecorator(notifier);
        notifier = new NotifyCounterDecorator(notifier);
        notifier = new TimeNotifierDecorator(notifier);
        // Same as: var notifier = new TimeNotifierDecorator(new NotifyCounterDecorator(new SmsNotifierDecorator(new Notifier())));

        notifier.Send("Hello World!");
    }
}