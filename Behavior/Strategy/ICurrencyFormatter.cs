namespace Behavior.Strategy;

public interface ICurrencyFormatter
{
    string Format(decimal value);
}