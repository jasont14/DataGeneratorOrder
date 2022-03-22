using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGeneratorOrder.Historic;
using DataGeneratorOrder.Model;

namespace DataGeneratorOrder.Historic
{
    public class GeneratorOrder
    {
        
        Order order = new Order();
        private Random _random;
        GeneratorConfig _config;        

        public GeneratorOrder(GeneratorConfig config)
        {
            _config = config;
            _random = new Random();            
        }

        public Order GenerateOrder(DateTime  _date)
        {
            GeneratorOrderDetail good = new GeneratorOrderDetail(_config);
            Guid guid = Guid.NewGuid();

            Order order = new Order();
            order.Id = guid;
            order.OrderDate = _date;
            order.Customer = _config.Customers[_random.Next(_config.Customers.Count)].Id;
            order.OrderDetails = good.GenerateOrderDetails(_config.Products, guid);

            return order;
            //If current year create up to current date

            //else for all years
        }

        public List<Order> GenerateOrders()
        {
            int currMonth = GetCurrentMonth();
            int orderDaysInMonth = _random.Next(29);
            int currYear = _config.StartYear;
            List<Order> orders = new List<Order>();

            for (int i = 0; i < currMonth; i++)
            {
                for (int j = 0; j < orderDaysInMonth; j++)
                {
                    for (int k = 0; k < _random.Next(1,_config.OrdersToCreatePerDay); k++)
                    {
                        DateTime orderDate = new DateTime(currYear, i + 1, _random.Next(1,28));
                        orders.Add(GenerateOrder(orderDate));
                    }
                }
            }
            return orders;
        }

        private int GetCurrentMonth()
        {
            DateTime dt = DateTime.Now;            
            return dt.Month;
        }
    }
}
