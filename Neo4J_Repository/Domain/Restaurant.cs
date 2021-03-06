using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Domain
{
    public class Restaurant
    {
        public String Id { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public String Phone { get; set; }

        public List<Product> Products { get; set; }

        public List<Bill> Bills { get; set; }

        public List<String> ProductLists { get; set; }

        public List<String> BillLists { get; set; }

        public Restaurant()
        {
            BillLists = new List<String>();
            ProductLists = new List<String>();
        }
    }
}
