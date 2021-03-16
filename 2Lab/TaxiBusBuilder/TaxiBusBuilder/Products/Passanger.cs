using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder
{
    class Passanger
    {
        public string Name { get; set; }
        public PassangerCategory Category  { get; set; }

        public override string ToString()
        {
            return this.GetType().ToString() + " " + Name + " " + Category;
        }

    }
}
