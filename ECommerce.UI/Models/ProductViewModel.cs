using ECommerce.Domain.Entities;
using System.Globalization;

namespace ECommerce.UI.Models
{
    public class ProductViewModel    {

        public string SummaryText { get; }

        public ProductViewModel(Product product, string culture = "en-US")
        {
            var PriceCulture = new CultureInfo(culture);
            SummaryText = string.Format(PriceCulture, "{0} ({1:C})", product.Name, product.UnitPrice);
        }

        public ProductViewModel(string name, decimal unitPrice, string culture = "en-US")
        {
            var PriceCulture = new CultureInfo(culture);
            SummaryText = string.Format(PriceCulture, "{0} ({1:C})", name, unitPrice);
        }
        

    }
}
