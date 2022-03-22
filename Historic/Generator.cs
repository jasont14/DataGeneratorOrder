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

        GeneratorProduct gp;

        GeneratorConfig config;
        DateTime _dateTime;

        public Generator()
        {
            config = new GeneratorConfig();

            gp = new GeneratorProduct(config);
            config.Products = gp.GenerateProducts();
            
            GeneratorCustomer gc = new GeneratorCustomer(config);
            config.Customers = gc.GenerateCustomers();

            GeneratorOrder goo = new GeneratorOrder(config);

            ProductList = config.Products;
            CustomerList = config.Customers;
            OrderList = goo.GenerateOrders();

        }

        public Generator(DateTime _time)
        {
            _dateTime = _time;
            config = new GeneratorConfig();

            GeneratorProduct gp = new GeneratorProduct(config);
            config.Products = gp.GenerateProducts();

            GeneratorCustomer gc = new GeneratorCustomer(config);
            config.Customers = gc.GenerateCustomers();

            //GeneratorOrder goo = new GeneratorOrder(config);

            ProductList = config.Products;
            CustomerList = config.Customers;
            //OrderList = goo.GenerateOrders();

        }

        public Order GenerateOrder()
        {
            GeneratorOrder goo = new GeneratorOrder(config);
            return goo.GenerateOrder(_dateTime);
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
