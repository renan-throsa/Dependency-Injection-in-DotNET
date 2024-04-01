
using ECommerce.Domain.Abstractions;
using ECommerce.Domain.Entities;

namespace ECommerce.Data.Repositories
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly CommerceContext context;
        public SqlProductRepository(CommerceContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
        public IEnumerable<Product> GetFeaturedProducts()
        {
            return
            from product in context.Products
            where product.IsFeatured
            select product;
        }
    }
}
