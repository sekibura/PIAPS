using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder.Products
{
    class Driver
    {
        public string Name { get; set; }
        public BoardType LicenseCategory { get; set; }

        public override string ToString()
        {
            return this.GetType().ToString() + " Имя водителя:" + Name + " Категория водительских прав:" + LicenseCategory.ToString();
        }
    }
}
