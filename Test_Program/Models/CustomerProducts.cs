using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Program.Models
{
    /// <summary>
    /// Which customer sells what products
    /// </summary>
    public class CustomerProducts
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Updates the prices of every product the customer sells into a new list
        /// </summary>
        /// <returns> A list of products with updated prices </returns>
        public List<Product> GetUpdatedPrices()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < Products.Count; i++)
            {
                Product product = new Product()
                {
                    Id = Products[i].Id,
                    Name = Products[i].Name,
                    Price = Products[i].Price * (1 - Customer.GetDiscount())
                };
                products.Add(product);
            }

            return products;
        }
    }
}
