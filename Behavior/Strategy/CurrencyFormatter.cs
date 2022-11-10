using System.Globalization;
using Common;

namespace Behavior.Strategy;

public interface ICurrencyFormatter
{
    string Format(decimal value);
}

public record DanishCurrencyFormatter : ICurrencyFormatter
{
    public string Format(decimal value)
    {
        var cultureInfo = new CultureInfo("da-DK");
        return value.ToString("C", cultureInfo);
    }
}

public record AmericanCurrencyFormatter : ICurrencyFormatter
{
    public string Format(decimal value)
    {
        var cultureInfo = new CultureInfo("en-US");
        return value.ToString("C", cultureInfo);
    }
}

public enum CurrencyFormat { Danish, American }

public static class CurrencyFormatterFactory
{
    private static readonly Dictionary<CurrencyFormat, ICurrencyFormatter> CurrencyFormatterDictionary = new()
    {
        { CurrencyFormat.Danish, new DanishCurrencyFormatter() },
        { CurrencyFormat.American, new AmericanCurrencyFormatter() }
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

public record StrategyRunner : IRunner
{
    public string Name => nameof(StrategyRunner);
        
    public void Run()
    {
        PrintCurrency(123.45m, CurrencyFormat.American);
        PrintCurrency(543.21m, CurrencyFormat.Danish);
    }

    private static void PrintCurrency(decimal value, CurrencyFormat currencyFormat)
    {
        var formatter = CurrencyFormatterFactory.GetCurrencyFormatter(currencyFormat);
        Console.WriteLine(formatter.Format(value));
    }
}