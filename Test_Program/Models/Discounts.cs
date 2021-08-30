using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Program.Models
{
    /// <summary>
    /// Interface implementation
    /// </summary>
    public class Discounts : IDiscounts
    {
        public int ProductsSold { get; set; }
        public double SpecialDeals { get; set; }
        public double OtherDeals { get; set; }

        public Discounts(int productsSold, double specialDeals, double otherDeals)
        {
            ProductsSold = productsSold;
            SpecialDeals = specialDeals;
            OtherDeals = otherDeals;
        }

        /// <summary>
        /// Gets the total discount
        /// </summary>
        /// <returns> the discount in percentages </returns>
        public double GetDiscount()
        {
            double productsSoldDiscount = Math.Round(Math.Log10(((double)ProductsSold)), 3) / 100;
            if (double.IsInfinity(productsSoldDiscount) || double.IsNegativeInfinity(productsSoldDiscount))
            {
                productsSoldDiscount = 0;
            }

            return Math.Round(productsSoldDiscount + SpecialDeals + OtherDeals,4);
        }
    }
}
