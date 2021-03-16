using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;

namespace TaxiBusBuilder.ConcreteBuilder
{
    class BusPasBuilder : PasBuilder
    {
        public override void BuildCategory()
        {
            passanger.Category = PassangerCategory.Preferential;
        }

        public override void BuildName()
        {
            passanger.Name = "Name Name";
        }
    }
}
