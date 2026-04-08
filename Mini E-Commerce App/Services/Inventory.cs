using System;
using System.Collections.Generic;
using System.Text;
using Mini_E_Commerce_App.Models;

namespace Mini_E_Commerce_App.Services
{
    public class Inventory
    {
        public List<Product> Products { get; set; } = new();

        public void Load()
        {
            var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.txt");
            var lines = System.IO.File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                Product prod = parts[2] == "Physical" ? new PhysicalProduct() : new DigitalProduct();
                prod.Name = parts[0];
                prod.Price = decimal.Parse(parts[1]);
                prod.Discount = decimal.Parse(parts[3]);
                prod.Stock = int.Parse(parts[4]);

                Products.Add(prod);
            }
        }
    }
}
