using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Models
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public string CardNumber { get; set; }

        public bool ProcessPayment()
        {
            return !string.IsNullOrEmpty(CardNumber) 
                &&
            CardNumber.All(char.IsDigit)
            && CardNumber.Length >= 8;
        }
    }
}
