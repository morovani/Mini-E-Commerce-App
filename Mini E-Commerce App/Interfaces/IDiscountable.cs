using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Interfaces
{
    public interface IDiscountable
    {
        decimal ApplyDiscount(decimal amount);
    }
}
