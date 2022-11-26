using Behavior.ChainOfResponsibility.OpenClosedRequestHandler;
using Common;

namespace Behavior.ChainOfResponsibility;

public class OpenClosedChainOfResponsibilityRunner : IRunner
{
    public string Name => nameof(OpenClosedChainOfResponsibilityRunner);
    public void Run()
    {
        var request = new Request("1");
        
        Console.WriteLine(request);

        var handler = new NumericalValueHandler();
        handler.SetNextHandler(new StringValueHandler());
        
        handler.Handle(request);
    }
}