namespace Behavior.Visitor;

public interface IElement
{
    void Accept(IVisitor visitor);
}