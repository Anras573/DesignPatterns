namespace Behavior.Interpreter.OnlyTerminalExpressions.Expressions;

/// <summary>
/// AbstractExpression
/// </summary>
public interface IRomanExpression
{
    void Interpret(RomanContext context);
}