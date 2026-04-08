using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.Eventing.Reader;
namespace Mini_E_Commerce_App.Models
{
    public class Cart
    {
        public List<CartItem> items { get; set; } = new();

        // METHOD OVERLOADING
        public void AddProduct(Product p)
        {
            AddProduct(p, 1);
        }

        public void AddProduct(Product p, int qty)
        {
            if (p.Stock < qty) return;
            
            p.Stock -= qty;

            var existingItem = items.FirstOrDefault(i => i.Product == p);

            if (existingItem != null)
                existingItem.Quantity += qty;
            else
                items.Add(new CartItem { Product = p, Quantity = qty });
        }

        public decimal GetTotal()
        {
            return items.Sum(i => i.GetSubtotal());
        }

        public static Cart operator +(Cart c1, Cart c2)
        {
            Cart result = new Cart();

            result.items.AddRange(c1.items);
            result.items.AddRange(c2.items);
            return result;
        }
    }
}
