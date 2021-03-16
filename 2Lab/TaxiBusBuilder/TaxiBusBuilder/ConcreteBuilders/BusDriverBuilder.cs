using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;

namespace TaxiBusBuilder.ConcreteBuilders
{
    class BusDriverBuilder : DriverBuilder
    {
        public override void BuildLicenseCategory()
        {
            driver.LicenseCategory = BoardType.Bus;
        }

        public override void BuildName()
        {
            driver.Name = "Driver Name";
        }
    }
}
