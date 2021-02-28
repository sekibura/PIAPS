using System;
using System.Collections.Generic;
using System.Text;
using TaxiBus.Cars;
using TaxiBus.Drivers;

namespace TaxiBus.ConcreteFactory
{
    class BusFabric : IAbstractFabric
    {
        public BoardBus boardBus = new BoardBus();

        public void BoardingDriver(BoardAnyCar board)
        {
            BusDriver busDriver = new BusDriver();
            //TaxiDriver busDriver = new TaxiDriver(); 
            board.SetDriver(busDriver);
        }

        public void BoardingPass(BoardAnyCar board)
        {
            for (int i = 0; i < ((BoardBus)board).NumberOfSeats; i++)
            {
                Passanger passanger = new Passanger();
                board.AddPassanger(passanger);
            }
        }

        public BoardAnyCar CreateBoard()
        {
            BoardBus boardBus = new BoardBus();
            return boardBus;
        }
    }
}
