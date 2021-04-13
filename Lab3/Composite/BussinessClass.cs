using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Composite
{
    class BussinessClass : IFlyableUnit
    {
        private List<IFlyableUnit> passangers = new List<IFlyableUnit>();
        private int maxNumOfPassengers=20;

        public int GetMaxNumOfPassengers()
        {
            return maxNumOfPassengers;
        }
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
    }
}
