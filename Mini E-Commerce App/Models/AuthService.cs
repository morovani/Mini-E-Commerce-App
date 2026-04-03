using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public class AuthService
    {
        public Customer? Login(string email, string password)
        {
            var lines = File.ReadAllLines("customers.txt");

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts[2] == email && parts[3] == password)
                {
                    string type = parts[4];

                    if (type == "VIP") return new VIPCustomer();
                    if (type == "Premium") return new PremiumCustomer();

                    return new RegularCustomer();
                }
            }

            return null;
        }
    }
}
