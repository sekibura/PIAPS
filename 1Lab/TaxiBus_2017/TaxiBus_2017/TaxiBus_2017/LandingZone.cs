using TaxiBus_2017.Cars;
using TaxiBus_2017.ConcreteFactory;

namespace TaxiBus_2017
{
    // абстрактная фабрика, которая выполняет посадку пассажиров в транспорт
    internal class LandingZone
    {
        public BoardAnyCar CreateCar(IAbstractFabric fabric)
        {
            BoardAnyCar board = fabric.CreateBoard();         
            fabric.BoardingPass(board);
            fabric.BoardingDriver(board);
            return board;
        }
      
    }
}