namespace Behavior.ChainOfResponsibility.OpenClosedRequestHandler;

public class NumericalValueHandler : RequestHandlerBase
{
    private int _value;
    
    protected override bool CanHandle(Request request)
    {
        return int.TryParse(request.Value, out _value);
    }

    protected override void HandleRequest(Request request)
    {
        Console.WriteLine($"Request Handled by {nameof(NumericalValueHandler)}: Value {_value}");
    }
}