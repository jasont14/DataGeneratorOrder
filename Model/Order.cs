using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorOrder.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid Customer { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderDetail> OrderDetails = new List<OrderDetail>();

        public override string ToString()
        {
            string delim = " | ";
            return Id.ToString() + delim + Customer.ToString() + delim + OrderDate.ToString()
                 + delim + OrderDetails.ToString();
        }
    }
}
