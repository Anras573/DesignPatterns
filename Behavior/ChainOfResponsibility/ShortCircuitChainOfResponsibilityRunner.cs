using Behavior.ChainOfResponsibility.ShortCircuitRequestHandler;
using Common;

namespace Behavior.ChainOfResponsibility;

public class ShortCircuitChainOfResponsibilityRunner : IRunner
{
    public string Name => nameof(ShortCircuitChainOfResponsibilityRunner);
    public void Run()
    {
        var request = new Request("1");

        var handler = new NumericalValueHandler();
        handler.SetNextHandler(new StringValueHandler());
        
        handler.Handle(request);

        request = new Request(Value: "Hello World!");
        
        handler.Handle(request);

        request = new Request(string.Empty);
        
        handler.Handle(request);
    }
}