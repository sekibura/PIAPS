﻿using System;
using System.Collections.Generic;
using System.Text;
using TaxiBus_2017.Cars;
using TaxiBus_2017.Drivers;

namespace TaxiBus_2017.ConcreteFactory
{
    class TaxiFabric : IAbstractFabric
    {
        
        public void BoardingDriver(BoardAnyCar board)
        {
            TaxiDriver taxiDriver = new TaxiDriver();
            board.SetDriver(taxiDriver);
        }
        public void BoardingPass(BoardAnyCar board)
        {
            for (int i = 0; i < ((BoardTaxi)board).NumberOfSeats; i++)
            {
                Passanger passanger = new Passanger();
                board.AddPassanger(passanger);
            }
        }

        public BoardAnyCar CreateBoard()
        {
            BoardTaxi boardTaxi = new BoardTaxi();
            return boardTaxi;
        }
    }
}
