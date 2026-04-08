using System;
using System.Collections.Generic;
using System.Text;
using Mini_E_Commerce_App.Models;
using System.IO;

namespace Mini_E_Commerce_App.Services
{
    public class AuthService
    {
        public Customer? Login(string email, string password)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts[0] == email && parts[1] == password)
                {
                    return parts[2] switch
                    {
                        "VIP" => new VIPCustomer { Name = parts[3] },
                        "Premium" => new PremiumCustomer { Name = parts[3] },
                        _ => new RegularCustomer { Name = parts[3] }
                    };
                }
            }

            return null;
        }
    }
}
