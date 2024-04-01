namespace ECommerce.Domain.Entities
{
    public class Money
    {
        public readonly decimal Amount;
        public readonly Currency Currency;

        public Money(decimal amount, Currency currency)
        {
            if (currency == null) throw new ArgumentNullException("currency");

            Amount = amount;
            Currency = currency;
        }

        public Money(decimal amount)
        {
            Amount = amount;
            Currency = new Currency(CurrencyCode.USD);
        }
    }
}
