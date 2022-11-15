namespace YlvasKaffelager.Services
{
    public class CoffeeDecorator : PriceDecorator
    {
        //Decorated class to give discount on purchases of coffee.
        private decimal discount = 0.05m; //5% discount.
        public CoffeeDecorator(ICalculateOrder calculate) : base(calculate) { }

        public virtual decimal CalculateTotalPrice(int amount, decimal coffeePrice)
        {
            return CalculateTotalPrice(amount, coffeePrice) * discount;
        }
    }
}
