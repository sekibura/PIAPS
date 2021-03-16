using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;

namespace TaxiBusBuilder.ConcreteBuilders
{
    class TaxiDriverBuilder : DriverBuilder
    {
        public override void BuildLicenseCategory()
        {
            driver.LicenseCategory = BoardType.Taxi;
        }

        public override void BuildName()
        {
            driver.Name = "Bus Driver";
        }
    }
}
