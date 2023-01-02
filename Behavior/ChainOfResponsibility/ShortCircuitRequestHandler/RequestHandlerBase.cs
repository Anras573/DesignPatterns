using System.Diagnostics.CodeAnalysis;
using Behavior.ChainOfResponsibility.Common;

namespace Behavior.ChainOfResponsibility.ShortCircuitRequestHandler;

public abstract class RequestHandlerBase : IRequestHandler
{
    private IRequestHandler _nextHandler = new NoopHandler();

    public void SetNextHandler([NotNull]RequestHandlerBase nextHandler) => _nextHandler = nextHandler;
    
    public void Handle(Request request)
    {
        if (CanHandle(request))
            HandleRequest(request);
        else
            _nextHandler.Handle(request);
    }

    protected abstract bool CanHandle(Request request);
    protected abstract void HandleRequest(Request request);
}