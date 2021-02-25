using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus.Passangers
{
    class BusPassanger:IPassanger
    {
        public string Name { get; }
        public BusPassanger()
        {
            Name = "name";
        }

        public BusPassanger(String Name)
        {
            this.Name = Name;
        }

        /// <summary>
        /// заплатить кондуктору
        /// </summary>
        public void toPay()
        {
            Console.WriteLine("Покупает билет");
        }
    }
}
