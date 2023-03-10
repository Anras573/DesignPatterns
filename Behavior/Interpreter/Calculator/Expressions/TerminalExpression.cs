namespace Behavior.Interpreter.Calculator.Expressions;

public class TerminalExpression : IExpression
{
    private readonly int _value;

    public TerminalExpression(int value)
    {
        _value = value;
    }
    public int Evaluate(CalculatorContext context)
    {
        return _value;
    }
}