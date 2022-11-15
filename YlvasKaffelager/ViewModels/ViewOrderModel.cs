using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YlvasKaffelager.ViewModels
{
    public class ViewOrderModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Brand { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
    }
}