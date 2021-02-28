using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus
{
    abstract class Driver
    {
        protected string name { get; set; }
        public string Name { get { return name; } }
        protected string cathegory { get; set; }
        public string Categoryes {
            get
            {
                return cathegory;
            }
        }
        public int Experience { get; }
        public Driver()
        {
            name = "name";
            cathegory = "all";
            Experience = 10;
        }
     
    }
}
