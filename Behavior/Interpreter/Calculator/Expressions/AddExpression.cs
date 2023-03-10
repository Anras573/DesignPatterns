namespace Behavior.Interpreter.Calculator.Expressions;

public class AddExpression : NonTerminalExpression
{
    public AddExpression(IExpression left, IExpression right) : base(left, right)
    {
    }

    public override int Evaluate(CalculatorContext context)
    {
        return Left.Evaluate(context) + Right.Evaluate(context);
    }
}