using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Composite
{
    class FirstClass : IFlyableUnit
    {
        private List<IFlyableUnit> passangers = new List<IFlyableUnit>();
        private int maxNumOfPassengers = 10;
        public void AddUnit(IFlyableUnit unit)
        {
            passangers.Add(unit);
        }

        public float GetWeight()
        {
            float weight = 0f;
            foreach (var passanger in passangers)
            {
                weight += passanger.GetWeight();
            }
            return weight;
        }

        public void RemoveAnyUnit()
        {
            throw new NotImplementedException();
        }

        public int GetMaxNumOfPassengers()
        {
            return maxNumOfPassengers;
        }
    }
}
