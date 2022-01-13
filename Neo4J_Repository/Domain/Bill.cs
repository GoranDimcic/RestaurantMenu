using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Domain
{
    public class Bill
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public float TotalPrice { get; set; }

        public Customer Customer { get; set; }

        public Restaurant Restaurant { get; set; }

        public Dictionary<string, int> Products;
    }
}
