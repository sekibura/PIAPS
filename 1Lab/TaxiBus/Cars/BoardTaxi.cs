using System;
using System.Collections.Generic;
using System.Text;
using TaxiBus.Drivers;

namespace TaxiBus.Cars
{
    class BoardTaxi:BoardAnyCar
    {
        public BoardTaxi() : base("к201кк", 4, "B") { }
        
        public override void SetDriver(Driver driver)
        {
            if (driver is TaxiDriver)
            {
                this.driver = driver;
            }
            else
            {
                Console.WriteLine("НЕ ТОТ ВОДИТЕЛЬ");
            }
        }
    }
}
