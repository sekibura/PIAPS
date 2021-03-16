using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;
using TaxiBusBuilder.ConcreteBuilder;
using TaxiBusBuilder.Directors;

namespace TaxiBusBuilder.ConcreteBuilders
{
    class BusBoardBuilder : BoardBuilder
    {
        private int seatsNumber = 30;
        public override void BuildDriver()
        {
            DriverDirector director = new DriverDirector();
            BusDriverBuilder busDriverBuilder = new BusDriverBuilder();
            director.Builder = busDriverBuilder;
            board.Driver= director.BuildDriver();

        }

        public override void BuildPassangers()
        {

            BusPasBuilder builder = new BusPasBuilder();
            PassangerDirector director = new PassangerDirector();
            director.Builder = builder;
            


            for (int i = 0; i < seatsNumber; i++)
            {
                board.passangers.Add(director.BuildPassanger());
            }
        }

        public override void BuildSeatsNumber()
        {
            board.SeatsNumber = seatsNumber;
        }

        public override void BuildType()
        {
            board.Type = BoardType.Bus;
        }
    }
}
