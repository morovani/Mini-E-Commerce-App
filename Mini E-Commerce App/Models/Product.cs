using System;
using System.Collections.Generic;
using System.Text;
using Mini_E_Commerce_App.Interfaces;

namespace Mini_E_Commerce_App.Models
{
    public abstract class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal _price;
        public decimal Price 
        { 
            get { return _price; } 
            set 
            {
                if (value < 0)
                    _price = value; 
            } 
        }

        public string? Description { get; set; }

        public bool HasDiscount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal FinalPrice 
        { 
            get { return GetFinalPrice(); }
        }

        public decimal GetFinalPrice()
        { 
            if (HasDiscount == true)
                return Price - (Price * (DiscountPercentage/100));

            return Price;
        }

        public abstract string GetProductType();
        public abstract string GetDetails();

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }
    }

    public class PhysicalProduct : Product, IDiscountable
    {
        public int StockQuantity { get; set; }
        public override string GetProductType()
        {
            return "Physical";
        }

        public override string GetDetails()
        {
            return $"{Name} - {GetFinalPrice():C} ({StockQuantity})";
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return GetFinalPrice();
        }

    }

    public class DigitalProduct : Product
    {
        public double FileSizeMB { get; set; }
        public override string GetProductType()
        {
            return "Physical";
        }

        public override string GetDetails()
        {
            return $"{Name} - {GetFinalPrice():C} ({FileSizeMB})";
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return GetFinalPrice();
        }
    }
}
