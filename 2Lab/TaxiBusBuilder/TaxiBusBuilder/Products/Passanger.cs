using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.PasCategory;

namespace TaxiBusBuilder
{
    class Passanger
    {
        public string Name { get; set; }
        public PassangerCategory Category  { get; set; }
        public float TicketPrice { get; set; }
        public int Age { get; set; }
        public string Options { get; set; }

        public override string ToString()
        {
            return this.GetType().ToString() + " " + Name + " " + Category;
        }

    }
}
