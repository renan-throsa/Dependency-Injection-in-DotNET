using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Abstractions
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetFeaturedProducts();
    }
}
