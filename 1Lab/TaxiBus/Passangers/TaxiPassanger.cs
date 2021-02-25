using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus.Passangers
{
    class TaxiPassanger : IPassanger
    {
        
        public string Name {get;}

        public int Seat { get; }

        public TaxiPassanger()
        {
            Name = "name";
            Seat = 0;
        }
        public TaxiPassanger(string Name, int Seat)
        {
            this.Name = Name;
            this.Seat = Seat;
        }
        /// <summary>
        /// заплатить водителю
        /// </summary>
        public void toPay()
        {
            Console.WriteLine("Отдает 150 рублей\n");
        }
    }
}
