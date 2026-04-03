using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Customer Customer { get; set; } = null!;

        public decimal GetTotal()
        {
            decimal total = Items.Sum(i => i.GetSubtotal());
            return Customer.ApplyDiscount(total);
        }
    }
}
