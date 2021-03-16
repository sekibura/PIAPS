using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus_2017
{
    interface IAbstractFabric
    {
        BoardAnyCar CreateBoard();

        void BoardingPass(BoardAnyCar board);

        void BoardingDriver(BoardAnyCar board);

    }
}
