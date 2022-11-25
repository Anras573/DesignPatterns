namespace Behavior.ChainOfResponsibility.OpenClosedRequestHandler;

public class StringValueHandler : RequestHandlerBase
{
    protected override bool CanHandle(Request request)
    {
        return !string.IsNullOrEmpty(request.Value);
    }

    protected override void HandleRequest(Request request)
    {
        Console.WriteLine($"Request Handled by {nameof(StringValueHandler)}: Value {request.Value}");
    }
}