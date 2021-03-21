using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Products;

namespace TaxiBusBuilder
{
    class Board
    {
        public List<Passanger> passangers = new List<Passanger>();
        public BoardType Type { get; set; }
        public int SeatsNumber{ get; set; }
        public Driver Driver { get; set; } = null;

        public void StartTrip()
        {
            if (isReadyForTrip())
            {
                Console.WriteLine("Поездка совершена!");
            }
            else
            {
                Console.WriteLine("Невозможно начать поездку!");
            }
        }
        private bool isReadyForTrip()
        {
            if(passangers.Count< SeatsNumber)
            {
                Console.WriteLine("Остались пустые места");
            }
            else if(passangers.Count > SeatsNumber)
            {
                Console.WriteLine("Количество пассажиров превышает количество мест!");
            }

            if(Driver == null)
            {
                Console.WriteLine("Нет водителя");
            }
            
            return (passangers.Count == SeatsNumber) && (Driver != null);
        }

        public override string ToString()
        {
            return this.GetType().ToString() + "\nТип транспорта: " + Type.ToString() + "\nКоличество мест: " + SeatsNumber.ToString() + "\nВодитель: " + Driver.ToString()+"\nКоличество пассажиров: "+ passangers.Count.ToString() ;
        }

    }
}
