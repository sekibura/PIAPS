using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus
{
    interface IAbstractFabric
    {
        public BoardAnyCar CreateBoard();
        public void BoardingPass(BoardAnyCar board);
        public void BoardingDriver(BoardAnyCar board);
    }
}
