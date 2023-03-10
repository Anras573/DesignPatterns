using Behavior.Interpreter.Calculator;
using Common;

namespace Behavior.Interpreter;

public class FullInterpreterRunner : IRunner
{
    public string Name => nameof(FullInterpreterRunner);
    public void Run()
    {
        Console.WriteLine("Please enter your calculation expression:");

        var expression = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(expression))
        {
            Console.WriteLine("Please enter an actual calculation!");
            expression = Console.ReadLine();
        }

        var parsedExpression = ExpressionParser.Parse(expression);
        
        Console.WriteLine(parsedExpression.Evaluate(new CalculatorContext()));
    }
}