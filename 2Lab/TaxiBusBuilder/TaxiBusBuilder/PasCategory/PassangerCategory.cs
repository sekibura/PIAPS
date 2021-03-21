using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder.PasCategory
{
    abstract class PassangerCategory
    {
        protected int Price { get; set; }
        protected string Type { get; set; }
        public float GetPrice()
        {
            return Price;
        }

    }
}
