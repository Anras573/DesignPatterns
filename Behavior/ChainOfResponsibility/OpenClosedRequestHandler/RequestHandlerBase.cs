using System.Diagnostics.CodeAnalysis;

namespace Behavior.ChainOfResponsibility.OpenClosedRequestHandler;

public abstract class RequestHandlerBase : IRequestHandler
{
    private IRequestHandler _nextHandler = new NoopHandler();

    public void SetNextHandler([NotNull]IRequestHandler nextHandler) => _nextHandler = nextHandler;
    public void Handle(Request request)
    {
        if (CanHandle(request))
            HandleRequest(request);
        
        _nextHandler.Handle(request);
    }
    
    protected abstract bool CanHandle(Request request);
    protected abstract void HandleRequest(Request request);
}