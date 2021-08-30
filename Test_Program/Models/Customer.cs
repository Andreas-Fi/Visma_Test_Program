using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Program.Models
{
    public class Customer : Discounts
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name, int productsSold, double specialDeals, double otherDeals)
            : base(productsSold, specialDeals, otherDeals)
        {
            Id = id;
            Name = name;
        }
    }
}