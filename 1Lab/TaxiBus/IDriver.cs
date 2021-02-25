using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBus
{
    interface IDriver
    {
        public String Name { get; }
        /// <summary>
        /// Водительская категория
        /// </summary>
        public String Category { get; }
        /// <summary>
        /// Стаж работы
        /// </summary>
        public int Experience { get; }
    }
}
