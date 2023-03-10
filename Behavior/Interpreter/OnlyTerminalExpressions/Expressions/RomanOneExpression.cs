namespace Behavior.Interpreter.OnlyTerminalExpressions.Expressions;

/// <summary>
/// TerminalExpression
/// </summary>
public class RomanOneExpression : IRomanExpression
{
    public void Interpret(RomanContext context)
    {
        while(context.Input - 9 >= 0)
        {
            context.Output += "IX";
            context.Input -= 9;
        }
        while(context.Input - 5 >= 0)
        {
            context.Output += "V";
            context.Input -= 5;
        }
        while(context.Input - 4 >= 0)
        {
            context.Output += "IV";
            context.Input -= 4;
        }
        while(context.Input - 1 >= 0)
        {
            context.Output += "I";
            context.Input -= 1;
        }
    }
}