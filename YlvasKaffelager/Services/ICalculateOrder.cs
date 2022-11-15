namespace YlvasKaffelager.Services
{
    public interface ICalculateOrder
    {
        decimal CalculateTotalPrice(int amount, decimal coffeePrice);
    }
}
