using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public abstract class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public abstract decimal ApplyDiscount(decimal total);
    }
    public class RegularCustomer : Customer
    {
        public override decimal ApplyDiscount(decimal total)
        {
            return total;
        }
    }

    public class PremiumCustomer : Customer
    {
        public override decimal ApplyDiscount(decimal total)
        {
            return total * 0.9m;
        }
    }

    public class VIPCustomer : Customer
    {
        public override decimal ApplyDiscount(decimal total)
        {
            return total * 0.8m;
        }
    }
}