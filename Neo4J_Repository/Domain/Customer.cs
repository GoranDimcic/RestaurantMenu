using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Domain
{
    public class Customer
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public float CreditCard { get; set; }

        public List<Bill> Bills { get; set; }
    }
}
