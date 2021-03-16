using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder.Builders
{
    abstract class  BoardBuilder
    {
        protected Board board;
        public void CreateBoard()
        {
            board = new Board();
        }

        public abstract void BuildType();
        public abstract void BuildSeatsNumber();
        public abstract void BuildDriver();
        public abstract void BuildPassangers();

        public Board GetBoard()
        {
            return board;
        }
    }
}
