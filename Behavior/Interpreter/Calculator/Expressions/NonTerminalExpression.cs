namespace Behavior.Interpreter.Calculator.Expressions;

public abstract class NonTerminalExpression : IExpression
{
    protected readonly IExpression Left;
    protected readonly IExpression Right;

    protected NonTerminalExpression(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }
    
    public virtual int Evaluate(CalculatorContext context)
    {
        throw new NotImplementedException();
    }
}