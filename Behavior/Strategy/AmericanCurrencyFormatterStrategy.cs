using System.Globalization;

namespace Behavior.Strategy;

public record AmericanCurrencyFormatterStrategy : ICurrencyFormatter
{
    private static readonly CultureInfo CultureInfo = new("en-US");
    
    public string Format(decimal value)
    {
        return value.ToString("C", CultureInfo);
    }
}