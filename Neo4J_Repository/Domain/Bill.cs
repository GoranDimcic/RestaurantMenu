using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Domain
{
    public class Bill
    {
        public String Id { get; set; }

        public String NumberBill { get; set; }

        public DateTime Date { get; set; }

        public float TotalPrice { get; set; }

        public Customer Customer { get; set; }

        public Restaurant Restaurant { get; set; }

        public List<String> Products { get; set; }

        public Bill()
        {
            TotalPrice = 0;
            Products = new List<String>();
        }
    }
}
