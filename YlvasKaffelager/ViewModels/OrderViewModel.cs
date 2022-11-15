using System.ComponentModel.DataAnnotations;

namespace YlvasKaffelager.ViewModels
{
    public class OrderViewModel
    {
        //DataAnnotations for validating orders.
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Cant place an order without email")]
        public string Email { get; set; }
        [Required]
        public int CoffeeId { get; set; }
        [Required]
        public int Amount { get; set; }
        public List<CoffeeItem> CoffeeItems { get; set; }
        public OrderViewModel()
        {
            CoffeeItems = new List<CoffeeItem>
                    {
                        new CoffeeItem
                        {
                            Value = 1,
                            Text = "Gevalia"
                        },
                        new CoffeeItem
                        {
                            Value = 2,
                            Text = "Lavazza"
                        },
                        new CoffeeItem
                        {
                            Value = 3,
                            Text = "Zoegas"
                        },
                        new CoffeeItem
                        {
                            Value = 4,
                            Text = "Löfbergs"
                        }
                    };
        }
        public class CoffeeItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }
    }
}