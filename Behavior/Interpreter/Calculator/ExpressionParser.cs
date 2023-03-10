using Behavior.Interpreter.Calculator.Expressions;

namespace Behavior.Interpreter.Calculator;

public static class ExpressionParser
{
    public static IExpression Parse(string expression)
    {
        // 2 + 4 * 6 / 2

        var tokens = expression.Split(' ');

        if (tokens.Length < 3)
            throw new Exception($"Could not parse expression: {expression}");

        var queue = new Queue<string>(tokens);

        var firstValueToken = queue.Dequeue();
        var commandToken = queue.Dequeue();
        var valueToken = queue.Dequeue();

        var firstTerminalExpression = new TerminalExpression(int.Parse(firstValueToken));
        var terminalExpression = new TerminalExpression(int.Parse(valueToken));
        var nonTerminalExpression = GetNonTerminalExpression(firstTerminalExpression, terminalExpression, commandToken);

        if (queue.Count == 0) return nonTerminalExpression;

        while (queue.Count > 1)
        {
            commandToken = queue.Dequeue();
            valueToken = queue.Dequeue();

            terminalExpression = new TerminalExpression(int.Parse(valueToken));
            nonTerminalExpression = GetNonTerminalExpression(nonTerminalExpression, terminalExpression, commandToken);
        }

        if (queue.Count == 1)
            throw new ParserException(
                $"Expression does not make sense: {expression}. Token not parsed in parser: {queue.Dequeue()}");

        return nonTerminalExpression;

        IExpression GetNonTerminalExpression(IExpression left, IExpression right, string token)
        {
            return token switch
            {
                "+" => new AddExpression(left, right),
                "-" => new SubtractExpression(left, right),
                "*" => new MultiplyExpression(left, right),
                "/" => new DivideExpression(left, right),
                _ => throw new ParserException($"{token} is not a valid token!")
            };
        }
    }
    
    private class ParserException : Exception
    {
        public ParserException(string message) : base(message) { }
    }
    
}