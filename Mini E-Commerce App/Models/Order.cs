using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new();
        public Customer Customer { get; set; }

        public decimal GetTotal()
        {
            decimal total = Items.Sum(i => i.Product.GetFinalPrice() * i.Quantity);
            return Customer.ApplyDiscount(total);
        }
    }
}
