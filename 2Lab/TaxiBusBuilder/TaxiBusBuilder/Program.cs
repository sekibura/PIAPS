using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.ConcreteBuilders;
using TaxiBusBuilder.Directors;

namespace TaxiBusBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardDirector boardDirector = new BoardDirector();

            BusBoardBuilder busBoardBuilder = new BusBoardBuilder();

            boardDirector.Builder = busBoardBuilder;

            Board Bus = boardDirector.BuildBoard();

            Console.WriteLine(Bus.ToString());
            Bus.StartTrip();
            Console.ReadLine();

        }
    }
}
