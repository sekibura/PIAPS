using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus
{   


    /// <summary>
    /// Представляет интерфейс для пассажиров
    /// </summary>
    interface IPassanger
    {
        string Name {get;}
        /// <summary>
        /// оплата проезда
        /// </summary>
        void toPay();
    }
}
