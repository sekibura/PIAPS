using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder.PasCategory
{
    class TaxiPassanger:PassangerCategory
    {
        public TaxiPassanger(TypesTaxiPas type)
        {
            Price = (int)type;
            Type = type.ToString();

        }
    }
}
