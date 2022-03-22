using System;
using Faker;
using DataGeneratorOrder.Historic;
using DataGeneratorOrder.Model;
using System.Collections.Generic;

namespace DataGeneratorOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Historic.GeneratorConfig config = new Historic.GeneratorConfig();
            config.CustomersToCreate = 10;
            config.ProductsToCreate = 10;

            Generator gen = new Generator();

            foreach (Customer cust in gen.CustomerList)
            {
                Console.WriteLine(cust.ToString());
            }

            foreach (Product p in gen.ProductList)
            {
                Console.WriteLine(p.ToString());
            }


            foreach (Order order in gen.OrderList)
            {
                Console.WriteLine(order.ToString());
            }

        }
    }
}
