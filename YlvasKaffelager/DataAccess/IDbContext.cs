using YlvasKaffelager.Models;

namespace YlvasKaffelager.DataAccess
{
    public interface IDbContext
    {
        List<Coffee> Coffees { get; set; }
        List<Order> Orders { get; set; }
        public Coffee GetCoffee(int? id);
        public void AddOrder(Order order);
    }
}
