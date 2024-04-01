using ECommerce.Domain.Abstractions;
using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Services
{
    public class CurrencyService : ICurrencyConverter
    {
        public Money Exchange(decimal amount, Currency targetCurrency)
        {
            return new Money(amount * ExchangeRate(targetCurrency), targetCurrency);
        }

        private decimal ExchangeRate(Currency targetCurrency)
        {
            var dic = new Dictionary<string, decimal>()
{
    {"USD", 1.0m}, // United States Dollar
    {"EUR", 0.9m}, // Euro
    {"JPY", 110.0m}, // Japanese Yen
    {"GBP", 0.8m}, // British Pound Sterling
    {"AUD", 1.4m}, // Australian Dollar
    {"CAD", 1.25m}, // Canadian Dollar
    {"CHF", 0.92m}, // Swiss Franc
    {"CNY", 6.45m}, // Chinese Yuan
    {"SEK", 9.03m}, // Swedish Krona
    {"NZD", 1.5m}, // New Zealand Dollar
    {"BRL", 5.2m}  // Brazilian Real
};


            return dic.GetValueOrDefault("USD") * dic.GetValueOrDefault(targetCurrency.ToString());
        }
    }
}
