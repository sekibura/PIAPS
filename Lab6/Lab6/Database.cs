using Lab6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Database : IObservable
    {
        private List<AcademicPerformance> _academicPerformances = new List<AcademicPerformance>();

        public Database(int numberGroups)
        {
            for (int i = 0; i < numberGroups; i++)
            {
                _academicPerformances.Add(new AcademicPerformance());
            }
        }

        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("\nSubject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("\nSubject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("\nSubject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(_academicPerformances);
            }
        }

        public void NewWeek()
        {
            foreach( AcademicPerformance group in _academicPerformances)
            {
                group.SetResults();
            }
            this.Notify();
        }
    }
}
