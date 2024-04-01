using ECommerce.Domain.Abstractions;
using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly IUserContext userContext;
        private readonly ICurrencyConverter converter;

        public ProductService(IProductRepository repository, IUserContext userContext, ICurrencyConverter converter)
        {
            if (repository == null)
                throw new ArgumentNullException("repository");

            if (userContext == null)
                throw new ArgumentNullException("userContext");

            if (converter == null)
                throw new ArgumentNullException("converter");

            this.repository = repository;
            this.userContext = userContext;
            this.converter = converter;
        }

        public IEnumerable<Product> GetFeaturedProducts()
        {
            Currency userCurrency = userContext.Currency();

            var products = repository.GetFeaturedProducts();

            if (userCurrency.isDefault())
                return
                from product in products
                select product.ApplyDiscountFor(userContext);

            return
                from product in products
                let unitPrice = product.UnitPrice
                let moneyConverted = converter.Exchange(amount: unitPrice, targetCurrency: userCurrency)
                select product.WithUnitPrice(moneyConverted).ApplyDiscountFor(userContext);
        }
    }
}
