namespace Behavior.Interpreter.OnlyTerminalExpressions.Expressions;

/// <summary>
/// TerminalExpression
/// </summary>
public class RomanTenExpression : IRomanExpression
{
    public void Interpret(RomanContext context)
    {
        while(context.Input - 90 >= 0)
        {
            context.Output += "XC";
            context.Input -= 90;
        }
        while(context.Input - 50 >= 0)
        {
            context.Output += "L";
            context.Input -= 50;
        }
        while(context.Input - 40 >= 0)
        {
            context.Output += "XL";
            context.Input -= 40;
        }
        while(context.Input - 10 >= 0)
        {
            context.Output += "X";
            context.Input -= 10;
        }
    }
}