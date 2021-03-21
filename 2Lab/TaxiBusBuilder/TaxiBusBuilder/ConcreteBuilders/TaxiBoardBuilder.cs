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
    class TaxiBoardBuilder : BoardBuilder
    {
        private int seatsNumber = 4;
        public override void BuildDriver()
        {
            DriverDirector director = new DriverDirector();
            TaxiDriverBuilder taxiDriverBuilder = new TaxiDriverBuilder();
            director.Builder = taxiDriverBuilder;
            if (board.Driver == null)
            {
                board.Driver = director.BuildDriver();
            }
            else
            {
                Console.WriteLine("Водительское место уже занято!");
            }
        }

        public override void BuildPassangers()
        {
            TaxiPasBuilder builder = new TaxiPasBuilder();
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
            board.Type = BoardType.Taxi;
        }
    }
}
