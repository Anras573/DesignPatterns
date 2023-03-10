using Behavior.Interpreter.OnlyTerminalExpressions;
using Behavior.Interpreter.OnlyTerminalExpressions.Expressions;
using Common;

namespace Behavior.Interpreter;

/// <summary>
/// Client
/// </summary>
public class OnlyTerminalInterpreterRunner : IRunner
{
    public string Name => nameof(OnlyTerminalInterpreterRunner);
    public void Run()
    {
        var expressions = new List<IRomanExpression>
        {
            new RomanHundredExpression(),
            new RomanTenExpression(),
            new RomanOneExpression()
        };

        var context = new RomanContext(5);

        foreach(var expression in expressions)
            expression.Interpret(context);

        Console.WriteLine($"Translating Arabic numerals to Roman numerals: 5 = {context.Output}");

        context = new RomanContext(81);

        foreach(var expression in expressions)
            expression.Interpret(context);

        Console.WriteLine($"Translating Arabic numerals to Roman numerals: 81 = {context.Output}");

        context = new RomanContext(733);

        foreach(var expression in expressions)
            expression.Interpret(context);

        Console.WriteLine($"Translating Arabic numerals to Roman numerals: 733 = {context.Output}");
    }
}