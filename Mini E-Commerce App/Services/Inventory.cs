using System;
using System.Collections.Generic;
using System.Text;
using Mini_E_Commerce_App.Models;

namespace Mini_E_Commerce_App.Services
{
    public class Inventory
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public List<Product> GetAllProducts()
        {
            return products.Values.ToList();
        }

        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.Id))
            {
                products.Add(product.Id, product);
            }
        }
        public Product? FindProduct(int id)
        {
            return products.ContainsKey(id) ? products[id] : null;
        }

        public List<Product> SearchProducts(string keyword)
        {
            return products.Values
                .Where(p => p.Name.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }

        public List<Product> FilterByCategory(string category)
        {
            if (category == "All")
                return GetAllProducts();

            return products.Values
                .Where(p => p.GetProductType() ==  category)
                .ToList();
        }
    }
}
