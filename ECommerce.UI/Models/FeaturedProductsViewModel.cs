namespace ECommerce.UI.Models
{
    public class FeaturedProductsViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; }

        public FeaturedProductsViewModel(IEnumerable<ProductViewModel> products)
        {
            Products = products;
        }


    }
}
