using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus
{
     class BoardAnyCar
    {
        private List<Passanger> passangers = new List<Passanger>();
        protected Driver driver = null;

        public string LicensePlate { get; }

        public int NumberOfSeats { get; }

        protected string cathegory { get; set; }
        public string Cathegory { get; }

      

        public BoardAnyCar()
        {
            LicensePlate = "000000";
            NumberOfSeats = 0;
        }
        public BoardAnyCar(String LicensePlate, int NumberOfSeats, string CathegoryV)
        {
            this.LicensePlate = LicensePlate;
            this.NumberOfSeats = NumberOfSeats;
            this.cathegory = CathegoryV;
        }


        virtual public void SetDriver(Driver driver)
        {
            this.driver = driver;
        }
       
       
        public void AddPassanger(Passanger passanger) 
        {
            passangers.Add(passanger);
        }
  
        public void StartTrip() 
        {
            if (driver == null)
            {
                Console.WriteLine("Поездка невозможна без водителя.");
            }
            else if (!String.Equals(driver.Categoryes,Cathegory))
            {
                Console.WriteLine("Водитель не имеет нужной категории");
            }
            else if(passangers.Count!=NumberOfSeats)
            {
                Console.WriteLine("Есть свободные места, дождитесь полной загрузки.");
            }
        }

        public void info()
        {
            Console.WriteLine("Car содержит " + passangers.Count + " пассажиров из "+ NumberOfSeats);
            if (driver == null)
            {
                Console.WriteLine("Поездка невозможна без водителя.");
            }
            else if (passangers.Count != NumberOfSeats)
            {
                Console.WriteLine("Есть свободные места, дождитесь полной загрузки." );
            }
            else
            {
                Console.WriteLine("ГОТОВ К ПОЕЗДКЕ");

            }
        }
    }
}
