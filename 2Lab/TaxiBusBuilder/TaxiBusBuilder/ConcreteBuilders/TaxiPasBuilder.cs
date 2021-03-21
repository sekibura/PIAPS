using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;
using TaxiBusBuilder.PasCategory;

namespace TaxiBusBuilder.ConcreteBuilder
{
    class TaxiPasBuilder : PasBuilder
    {
        public override void BuildAge()
        {
            passanger.Age = 30;
        }

        public override void BuildCategory()
        {
            passanger.Category = new TaxiPassanger(TypesTaxiPas.adult);
        }

        public override void BuildName()
        {
            passanger.Name = "NameT NameT";
        }

        public override void BuildOptions()
        {
            if (passanger.Age < 14)
            {
                passanger.Options = "Детское кресло";
            }
        }

        public override void BuildPrice()
        {
            passanger.TicketPrice = passanger.Category.GetPrice();
        }
    }
}
