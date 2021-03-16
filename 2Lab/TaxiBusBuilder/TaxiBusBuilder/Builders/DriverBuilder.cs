using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Products;

namespace TaxiBusBuilder.Builders
{
    abstract class DriverBuilder
    {
        protected Driver driver;

        public void CreateDriver()
        {
            driver = new Driver();
        }

        abstract public void BuildName();

        abstract public void BuildLicenseCategory();

        public Driver GetDriver()
        {
            return driver;
        }

    }
}
