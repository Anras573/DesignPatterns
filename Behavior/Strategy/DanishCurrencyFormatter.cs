﻿using System.Globalization;

namespace Behavior.Strategy;

public record DanishCurrencyFormatter : ICurrencyFormatter
{
    private static readonly CultureInfo CultureInfo = new("da-DK");
    
    public string Format(decimal value)
    {
        return value.ToString("C", CultureInfo);
    }
}