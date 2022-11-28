using Common;

namespace Behavior.Strategy;

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
        Console.WriteLine($"{currencyFormat}: {formatter.Format(value)}");
    }
}