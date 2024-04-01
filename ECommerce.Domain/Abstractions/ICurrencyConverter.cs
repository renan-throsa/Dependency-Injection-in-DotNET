using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Abstractions
{
    public interface ICurrencyConverter
    {
        Money Exchange(decimal amount, Currency targetCurrency);
    }

}
