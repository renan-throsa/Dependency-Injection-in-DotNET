
using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Abstractions
{
    public interface IProductService
    {
        IEnumerable<Product> GetFeaturedProducts();
    }
}
