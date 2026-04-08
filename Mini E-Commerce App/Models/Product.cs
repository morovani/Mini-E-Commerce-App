using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public abstract class Product : IDiscountable, IComparable<Product>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public decimal GetFinalPrice()
        {
            if (Discount > 0)
                return Price - (Price * (Discount / 100));

            return Price;
        }
        public int CompareTo(Product? other)
        {
            return Price.CompareTo(other?.Price);
        }
        public abstract string GetDetails();
    }

    public class PhysicalProduct : Product
    {
        public override string GetDetails()
        {
            return $"{Name} (Physical)";
        }
    }

    public class DigitalProduct : Product
    {
        public override string GetDetails()
        {
            return $"{Name} (Digital)";
        }
    }
    public class DiscountedProduct : Product
    {
        public override string GetDetails()
        {
            return $"{Name} (Discounted)";
        }
    }
}
