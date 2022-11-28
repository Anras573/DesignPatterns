namespace Behavior.Strategy;

public static class CurrencyFormatterFactory
{
    private static readonly Dictionary<CurrencyFormat, ICurrencyFormatter> CurrencyFormatterDictionary = new()
    {
        { CurrencyFormat.Danish, new DanishCurrencyFormatterStrategy() },
        { CurrencyFormat.American, new AmericanCurrencyFormatterStrategy() }
    };

    public static ICurrencyFormatter GetCurrencyFormatter(CurrencyFormat currencyFormat)
    {
        if (CurrencyFormatterDictionary.TryGetValue(currencyFormat, out var formatter))
        {
            return formatter;
        }

        throw new ArgumentException($"Unknown Currency: {currencyFormat}");
    }
}