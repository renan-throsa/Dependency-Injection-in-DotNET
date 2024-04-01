using ECommerce.Domain.Abstractions;
using ECommerce.Domain.Entities;

namespace ECommerce.UI.Others
{
    public class AspNetUserContextAdapter : IUserContext
    {
        private static HttpContextAccessor Accessor = new();

        public Currency Currency()
        {
            return new Currency(CurrencyCode.BRL);
        }

        public bool IsInRole(Role role)
        {
            return Accessor.HttpContext!.User.IsInRole(role.ToString());
        }
    }
}
