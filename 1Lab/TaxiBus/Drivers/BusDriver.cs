using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus.Drivers
{
    class BusDriver:IDriver
    {
        public string Name { get; }
        public string Category { get; }
        public int Experience { get; }
    }
}
