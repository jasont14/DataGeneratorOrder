using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorOrder.Model
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid Product { get; set; }

        public Guid OrderId { get ; set; }
        public int Quanity { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            string delim = " | ";

            return Id.ToString() + delim + Product.ToString() + delim + OrderId.ToString() + Quanity.ToString() + delim + Price.ToString() ;
        }
    }

}
