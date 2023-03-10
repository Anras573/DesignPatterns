namespace Behavior.Interpreter.OnlyTerminalExpressions.Expressions;

/// <summary>
/// TerminalExpression
/// </summary>
public class RomanHundredExpression : IRomanExpression
{
    public void Interpret(RomanContext context)
    {
        while(context.Input - 900 >= 0)
        {
            context.Output += "CM";
            context.Input -= 900;
        }
        while(context.Input - 500 >= 0)
        {
            context.Output += "D";
            context.Input -= 500;
        }
        while(context.Input - 400 >= 0)
        {
            context.Output += "CD";
            context.Input -= 400;
        }
        while(context.Input - 100 >= 0)
        {
            context.Output += "C";
            context.Input -= 100;
        }
    }
}