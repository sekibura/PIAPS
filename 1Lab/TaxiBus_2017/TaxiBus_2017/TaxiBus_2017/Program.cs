using System;
using TaxiBus_2017;
using TaxiBus_2017.Cars;
using TaxiBus_2017.ConcreteFactory;

namespace TaxiBus_2017
{
    class Program
    {
        //Обеспечить контроль загрузки и готовности к отправлению автобусов и такси.
        //Водитель такси и автобуса имеют права разной категории.Без водителя машина не поедет.Два водителя в одну машину сесть не могут.
        //Без пассажиров машины не поедут.Есть лимит загрузки машин. Для автобуса 30 чел.Для такси -4 чел.
        //Рекомендуется для водителя применить паттерн синглтон.  

        static void Main(string[] args)
        {

            LandingZone landingZone = new LandingZone();
            BusFabric busFabric = new BusFabric();
            TaxiFabric taxiFabric = new TaxiFabric();



            BoardAnyCar boardBus = landingZone.CreateCar(busFabric);
            BoardAnyCar boardTaxi = landingZone.CreateCar(taxiFabric);

            boardBus.info();
            boardTaxi.info();

            Console.ReadLine();
        }
    }
}
