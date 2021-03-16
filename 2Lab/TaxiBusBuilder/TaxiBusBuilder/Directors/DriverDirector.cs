using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;
using TaxiBusBuilder.Products;

namespace TaxiBusBuilder.Directors
{
    class DriverDirector
    {
        public DriverBuilder Builder { get; set; }

        public Driver BuildDriver()
        {
            Builder.CreateDriver();
            Builder.BuildLicenseCategory();
            Builder.BuildName();
            return Builder.GetDriver();
        }
    }
}
