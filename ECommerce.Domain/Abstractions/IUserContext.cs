using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Abstractions
{
    public interface IUserContext
    {
        bool IsInRole(Role role);
        Currency Currency();
    }
    public enum Role { PreferredCustomer = 0 }    

}
