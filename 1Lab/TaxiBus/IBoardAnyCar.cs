using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus
{
    interface IBoardAnyCar
    {
        /// <summary>
        /// Регистрационный номер ТС
        /// </summary>
        public string LicensePlate { get; }
        /// <summary>
        /// Количество посадочных мест
        /// </summary>
        public int NumberOfSeats { get; }
        /// <summary>
        /// Добавить водителя
        /// </summary>
        public void AddDriver();
        /// <summary>
        /// Добавить пассажира
        /// </summary>
        public void AddPassanger();
        /// <summary>
        /// Начать поездку
        /// </summary>
        public void StartTrip();
    }

}
