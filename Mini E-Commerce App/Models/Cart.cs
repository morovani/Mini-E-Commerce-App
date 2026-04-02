using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Mini_E_Commerce_App.Models
{
    public class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public List<CartItem> Items
        {
            get { return items; }
        }

        // METHOD OVERLOADING
        public void AddProduct(Product product)
        {
            AddProduct(product, 1);
        }

        public void AddProduct(Product product, int quantity)
        {
            var existingItem = items.FirstOrDefault(i => i.Product.Id == product.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }

        public void RemoveProduct(Product product)
        {
            items.RemoveAll(i => i.Product.Id == product.Id);
        }

        public void UpdateQuantity(Product product, int newQuantity)
        {
            var item = items.FirstOrDefault(i => i.Product.Id == product.Id);

            if (item != null)
            {
                if (newQuantity <= 0)
                    items.Remove(item);
                else
                    item.Quantity = newQuantity;
            }
        }

        public decimal GetTotal()
        {
            return items.Sum(i => i.GetSubtotal());
        }

        public static Cart operator +(Cart c1, Cart c2)
        {
            Cart result = new Cart();

            foreach (var item in c1.Items)
                result.AddProduct(item.Product, item.Quantity);

            foreach (var item in c2.Items)
                result.AddProduct(item.Product, item.Quantity);

            return result;
        }
    }
}
