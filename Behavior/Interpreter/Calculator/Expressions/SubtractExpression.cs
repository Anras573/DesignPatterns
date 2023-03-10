namespace Behavior.Interpreter.Calculator.Expressions;

public class SubtractExpression : NonTerminalExpression
{
    public SubtractExpression(IExpression left, IExpression right) : base(left, right)
    {
    }

    public override int Evaluate(CalculatorContext context)
    {
        return Left.Evaluate(context) - Right.Evaluate(context);
    }
}