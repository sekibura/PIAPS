using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder.PasCategory
{
    class BusPassanger:PassangerCategory
    {
        public BusPassanger(TypesBusPas type)
        {
            Price = (int)type;
            Type = type.ToString();

        }
    }
}
