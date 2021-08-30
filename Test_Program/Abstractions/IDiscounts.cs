using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Program.Models
{
    /// <summary>
    /// Discount interface
    /// </summary>
    interface IDiscounts
    {
        int ProductsSold { get; set; }
        double SpecialDeals { get; set; }
        double OtherDeals { get; set; }

        double GetDiscount();
    }
}
