using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGeneratorOrder.Model;


namespace DataGeneratorOrder.Historic
{
    public class GeneratorOrderDetail
    {
        private  int _OrderDetailsToCreate;
        private Random _random;

        public  GeneratorOrderDetail(GeneratorConfig config)
        {
            _random = new Random();
            _OrderDetailsToCreate = _random.Next(1, 5);
        }

        private OrderDetail GenerateOrderDetail(List<Product> products, Guid orderId)
        {
            OrderDetail OrderDetail = new OrderDetail();

            OrderDetail.Id = Guid.NewGuid();
            OrderDetail.OrderId = orderId;
            OrderDetail.Quanity = _random.Next();
            Guid prodId = products[_random.Next(products.Count)].id;
            OrderDetail.Product = prodId;
            OrderDetail.Price = products.Where(x => x.id == prodId).Select(x => x.BasePrice).FirstOrDefault();

            return OrderDetail;
        }

        public  List<OrderDetail> GenerateOrderDetails(List<Product> products, Guid orderId)
        {
            List<OrderDetail> OrderDetails = new List<OrderDetail>();

            for (int i = 0; i < _OrderDetailsToCreate; i++)
            {
                OrderDetails.Add(GenerateOrderDetail(products, orderId));
            }

            return OrderDetails;
        }

    }
}
