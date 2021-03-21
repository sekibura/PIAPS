using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;
using TaxiBusBuilder.PasCategory;

namespace TaxiBusBuilder.ConcreteBuilder
{
    class BusPasBuilder : PasBuilder
    {
        public override void BuildAge()
        {
            passanger.Age = 30;
        }

        public override void BuildCategory()
        {
            passanger.Category = new BusPassanger(TypesBusPas.adult);
        }

        public override void BuildName()
        {
            passanger.Name = "Name Name";
        }

        public override void BuildOptions()
        {
            
        }

        public override void BuildPrice()
        {
            passanger.TicketPrice = passanger.Category.GetPrice();
        }
    }
}
