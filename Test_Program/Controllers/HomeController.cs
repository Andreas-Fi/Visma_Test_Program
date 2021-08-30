using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Program.Models;

namespace Test_Program.Controllers
{
    public class HomeController : Controller
    {
        static private List<Customer> customers = new List<Customer>();
        static private List<Product> products = new List<Product>();
        static private List<CustomerProducts> customerProducts = new List<CustomerProducts>();
        static private bool seeded = false;

        /// <summary>
        /// Home page
        /// shows all of the customers in a list
        /// website.com/
        /// </summary>
        /// <returns> The view </returns>
        public IActionResult Index()
        {
            //Seeds the program only once
            if (!seeded)
            {
                Seed();
                seeded = true;
            }

            return View(customers);
        }

        /// <summary>
        /// View for viewing the products and prices for a company
        /// website.com/Details/id
        /// </summary>
        /// <param name="id"> Customer ID </param>
        /// <returns> View to the user </returns>
        public ActionResult Details(int id)
        {
            return View(new CustomerProducts() { Customer = customerProducts[id].Customer, Products = customerProducts[id].GetUpdatedPrices() });
        }

        /// <summary>
        /// Seeds the information into the program
        /// Would be replaced by databases
        /// </summary>
        static private void Seed()
        {
            customers.Add(new Customer(0, "ABC", 245621, 0, 0.2));
            customers.Add(new Customer(1, "ABB", 769435, 0.3, 0));
            customers.Add(new Customer(2, "New company", 0, 0, 0));

            products.Add(new Product() { Id = 0, Name = "Soffa", Price = 400 });
            products.Add(new Product() { Id = 1, Name = "Bed", Price = 300 });
            products.Add(new Product() { Id = 2, Name = "Chair", Price = 50 });
            products.Add(new Product() { Id = 3, Name = "Table", Price = 100 });
            products.Add(new Product() { Id = 4, Name = "Lamp", Price = 30 });

            customerProducts.Add(new CustomerProducts() { Customer = customers[0], Products = products.GetRange(1, 3) });
            customerProducts.Add(new CustomerProducts() { Customer = customers[1], Products = products });
            customerProducts.Add(new CustomerProducts() { Customer = customers[2], Products = products.GetRange(3, 2) });
        }
    }
}
