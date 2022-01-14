using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Domain
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Weight { get; set; }

        public float Price { get; set; }

        public ProductType ProductType { get; set; }

        public string RestaurantName { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
