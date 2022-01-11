﻿using System;
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

        public Dictionary<object, int> kolicina; //meni
    }
}