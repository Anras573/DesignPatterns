namespace Behavior.Interpreter.Calculator.Expressions;

public class MultiplyExpression : NonTerminalExpression
{
    public MultiplyExpression(IExpression left, IExpression right) : base(left, right)
    {
    }

    public override int Evaluate(CalculatorContext context)
    {
        return Left.Evaluate(context) * Right.Evaluate(context);
    }
}