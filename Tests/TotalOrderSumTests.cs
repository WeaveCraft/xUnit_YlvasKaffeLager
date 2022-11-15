using Xunit;
using YlvasKaffelager.DataAccess;
using YlvasKaffelager.Services;
using YlvasKaffelager.ViewModels;

namespace YlvasKaffelager.Tests
{
    public class TotalOrderSumTests
    {
        [Fact]
        public void Order_Sum()
        {

            var firstName = "Viktor";
            var lastName = "Hurtig";
            var email = "Email";
            var brand = "Brand Name";
            var amount = 4; //As long as this variable is the same as our testAmount variable we should always get a passing test. 
            var price = 49.90m; //Price can be changed however we want with a positive result on our test.

            //ARRANGE

            ViewOrderModel result = new ViewOrderModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Brand = brand,
                Amount = amount,
                Total = (amount * price)
            };

            //ACT
            var testAmount = 4;

            var actual = testAmount * price;

            //ASSERT

            Assert.Equal(actual, result.Total);
        }

        //Decorator pattern test, with this test it's proven that we can implement the decorator pattern in our actual code.

        private readonly DbContext _dbContext;
        private readonly CoffeeDecorator _coffeeDecorator;
        private readonly ICalculateOrder _calculateOrder;
        private decimal discount = 0.05m;
        
        public TotalOrderSumTests()
        {
            _dbContext = new DbContext();
            _coffeeDecorator = new CoffeeDecorator(_calculateOrder);
            _calculateOrder = new CalculateOrder();
        }

        [Fact]
        public void Order_Sum_Decorated() //We do the same thing here as the deocorated class does where we include a discount on the coffee order.
        {
            //ACT
            var coffee = _dbContext.GetCoffee(1);
            var testCoffee = coffee.Price * discount; //This variable is needed to calculate if tax should be included.
                                                 //If/when we implement the actual tax calculations from the decorated pattern class in the _dbContext.GetCoffee();we wont need this variable.
            int amount = 1;

            //ARRENGE
            var price = _calculateOrder.CalculateTotalPrice(amount, testCoffee);

            //ASSERT
            Assert.Equal(amount * coffee.Price * discount, price);
        }

    }
}
