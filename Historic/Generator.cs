using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGeneratorOrder.Model;

namespace DataGeneratorOrder.Historic
{
    public class Generator
    {
        public List<Customer> CustomerList { get; set; }
        public List<Order> OrderList { get; set; }
        public List<Product> ProductList{ get; set; }

        public Generator()
        {
            GeneratorConfig config = new GeneratorConfig();

            GeneratorProduct gp = new GeneratorProduct(config);
            config.Products = gp.GenerateProducts();
            
            GeneratorCustomer gc = new GeneratorCustomer(config);
            config.Customers = gc.GenerateCustomers();

            GeneratorOrder goo = new GeneratorOrder(config);

            ProductList = config.Products;
            CustomerList = config.Customers;
            OrderList = goo.GenerateOrders();

        }

        public Generator(GeneratorConfig config)
        {
            //GeneratorConfig config = new GeneratorConfig();

            GeneratorProduct gp = new GeneratorProduct(config);
            config.Products = gp.GenerateProducts();

            GeneratorCustomer gc = new GeneratorCustomer(config);
            config.Customers = gc.GenerateCustomers();

            GeneratorOrder good = new GeneratorOrder(config);

        }

    }
}
