namespace YlvasKaffelager.Services
{
    public class CalculateOrder : ICalculateOrder
    {
        public decimal CalculateTotalPrice(int amount, decimal coffeePrice)
        {
            return amount * coffeePrice;
        }
    }
}
