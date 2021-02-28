using TaxiBus.Cars;
using TaxiBus.ConcreteFactory;

namespace TaxiBus
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