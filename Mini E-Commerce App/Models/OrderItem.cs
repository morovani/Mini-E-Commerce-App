using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public class OrderItem
    {
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }

        public decimal GetSubtotal()
        {
            return Product.GetFinalPrice() * Quantity;
        }
    }
}
