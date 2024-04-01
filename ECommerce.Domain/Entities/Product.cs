using ECommerce.Domain.Abstractions;

namespace ECommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsFeatured { get; set; }

        public Product()
        {
            Name = string.Empty;
        }

        public Product(int id, string name, decimal unitPrice, bool isFeatured)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            IsFeatured = isFeatured;
        }

        public Product ApplyDiscountFor(IUserContext user)
        {
            bool preferred = user.IsInRole(Role.PreferredCustomer);

            decimal discount = preferred ? .95m : 1.00m;
            return new Product(Id, name: Name, unitPrice: UnitPrice * discount, IsFeatured);
        }

        public Product WithUnitPrice(Money money)
        {
            return new Product(Id, name: Name, unitPrice: money.Amount, IsFeatured);
        }
    }
}
