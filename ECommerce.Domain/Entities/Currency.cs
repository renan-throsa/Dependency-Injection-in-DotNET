namespace ECommerce.Domain.Entities
{
    public class Currency
    {
        public readonly CurrencyCode Code;

        public Currency()
        {
            Code = CurrencyCode.USD;
        }
        public Currency(CurrencyCode code)
        {
            Code = code;
        }

        public bool isDefault()
        {
            return Code == CurrencyCode.USD;
        }

        public override string ToString()
        {
            return Code.ToString();
        }
    }
}

