namespace Behavior.Interpreter.Calculator.Expressions;

public interface IExpression
{
    int Evaluate(CalculatorContext context);
}