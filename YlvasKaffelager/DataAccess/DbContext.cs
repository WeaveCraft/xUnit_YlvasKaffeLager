using YlvasKaffelager.Models;

namespace YlvasKaffelager.DataAccess
{
    public class DbContext : IDbContext
    {
        public List<Coffee> Coffees { get; set; } = new List<Coffee>
        {
            new Coffee
            {
                Id = 1,
                Brand = "Gevalia",
                Price = 29.90m
            },
            new Coffee
            {
                Id = 2,
                Brand = "Lavazza",
                Price = 49.90m
            },
            new Coffee
            {
                Id = 3,
                Brand = "Zoegas",
                Price = 59.90m
            },
            new Coffee
            {
                Id = 4,
                Brand = "Löfbergs",
                Price = 39.90m
            }
        };

        public List<Order> Orders { get; set; }

        public DbContext()
        {
            Orders = new List<Order>();
        }

        public Coffee GetCoffee(int? Id)
        {
            var coffee = Coffees.FirstOrDefault(c => c.Id == Id);
            return coffee;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}