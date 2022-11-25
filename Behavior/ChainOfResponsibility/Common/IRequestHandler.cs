namespace Behavior.ChainOfResponsibility;

public interface IRequestHandler
{
    void Handle(Request request);
}