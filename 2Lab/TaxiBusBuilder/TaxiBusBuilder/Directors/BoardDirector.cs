using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;

namespace TaxiBusBuilder.Directors
{
    class BoardDirector
    {
        public BoardBuilder Builder { get; set; }

        public Board BuildBoard()
        {
            Builder.CreateBoard();
            Builder.BuildDriver();
            Builder.BuildSeatsNumber();
            Builder.BuildType();
            Builder.BuildPassangers();
            return Builder.GetBoard();
        }
    }
}
