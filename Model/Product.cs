using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorOrder.Model
{
    public class Product
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public double BasePrice   { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return id.ToString() + " | " + Name;
        }

    }
}
