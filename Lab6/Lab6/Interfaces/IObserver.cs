using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.Interfaces
{
    interface IObserver
    {
        // Получает обновление от издателя
        void Update(Object subject);
    }
}
