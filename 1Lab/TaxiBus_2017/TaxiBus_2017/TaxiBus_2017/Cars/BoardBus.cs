using System;
using System.Collections.Generic;
using System.Text;
using TaxiBus_2017.Drivers;

namespace TaxiBus_2017.Cars
{
    class BoardBus:BoardAnyCar
    { 
        public BoardBus() : base("dhjhj", 30, "D") { }
        public override void SetDriver(Driver driver)
        {
            if(driver is BusDriver)
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
