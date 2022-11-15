namespace YlvasKaffelager.Services
{
    public abstract class PriceDecorator : ICalculateOrder //Decorated class is tested in our YlvasKaffelager.Yests/OrdersControllerMockTests.cs Where we see if it's possible to implement the decorated class onto our production.
    {
        private ICalculateOrder _calculate;
        public decimal CalculateTotalPrice(int amount, decimal coffeePrice)
        {
            return _calculate.CalculateTotalPrice(amount, coffeePrice);
        }

        public PriceDecorator(ICalculateOrder calculate)
        {
            _calculate = calculate;
        }
    }
}
