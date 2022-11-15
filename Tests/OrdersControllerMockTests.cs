using Moq;
using Xunit;
using YlvasKaffelager.DataAccess;
using YlvasKaffelager.Models;

namespace YlvasKaffelager.Tests
{
    public class OrdersControllerMockTests
    {
        public Mock<IDbContext> _context { get; set; }
        public IDbContext _sut { get; set; }
        public OrdersControllerMockTests()
        {
            var coffee = new Coffee();
            coffee = null;

            var testCoffee = new Coffee
            {
                Id = 1,
                Brand = "Gevalia",
                Price = 29.90m
            };
            _context = new Mock<IDbContext>();
            _context.Setup(x => x.GetCoffee(8)).Returns(coffee);
            _context.Setup(x => x.GetCoffee(1)).Returns(testCoffee);
            _sut = _context.Object;
        }

        [Fact]
        public void GetCoffee_HandleNull()
        {
            //ACT
            var expected = new Coffee();
            expected = null;

            //ARRENGE
            var result = _sut.GetCoffee(8);

            //ASSERT
            Assert.Equal(expected, result);
        }
        [Fact]

        public void GetCoffee_WithExisitingId()
        {
            //ACT
            var actualCoffee = new Coffee
            {
                Id = 1,
                Brand = "Gevalia",
                Price = 29.90m
            };

            //ARRENGE
            var result = _sut.GetCoffee(1);

            //ASSERT
            Assert.Equal(actualCoffee.Price, result.Price);
            Assert.Equal(actualCoffee.Brand, result.Brand);
        }
    }
}
