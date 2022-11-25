namespace Behavior.ChainOfResponsibility.OpenClosedRequestHandler;

public class NoopHandler : IRequestHandler
{
    public void Handle(Request request)
    {
        Console.WriteLine($"Request Handled by {nameof(NoopHandler)}: Value {request.Value}");
        // noop
    }
}