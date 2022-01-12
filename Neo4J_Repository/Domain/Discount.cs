using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Domain
{
    public class Discount
    {
        public string Id { get; set; }

        public string Tip { get; set; }

        public ProductType ProductType { get; set; }

        public int Discounts { get; set; }

        public string CustomerName { get; set; }

        public Customer Customer { get; set; }

        public string RestaurantName { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
