using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;

namespace TaxiBusBuilder.ConcreteBuilder
{
    class TaxiPasBuilder : PasBuilder
    {
        public override void BuildCategory()
        {
            passanger.Category = PassangerCategory.Adult;
        }

        public override void BuildName()
        {
            passanger.Name = "NameT NameT";
        }
    }
}
