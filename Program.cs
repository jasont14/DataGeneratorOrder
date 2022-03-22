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

            DateTime dt = new DateTime(2022, 3, 21);

            Generator gen = new Generator(dt);
            Order od = gen.GenerateOrder();

            Console.WriteLine(od.ToString());

            //To Do.  For Order Stream.  Need to Load Customers, Products in List and update config


            

           /* foreach (Customer cust in gen.CustomerList)
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
            }*/

            

        }
    }
}
