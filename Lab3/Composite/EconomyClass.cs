using Lab3.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Composite
{
    class EconomyClass : IFlyableUnit
    {
        private List<IFlyableUnit> passangers = new List<IFlyableUnit>();
        private int maxNumOfPassengers = 150;
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

        public void RemoveOverload(float value)
        {
           // Console.WriteLine(GetWeight());
            List<IFlyableUnit> pasWithBag = passangers.FindAll(pas => pas.GetWeight() > 0);
            float deltaWeight =  value / pasWithBag.Count;
            float removedWeight = 0;

            for (int i = 0; i < pasWithBag.Count; i++)
            {   if (pasWithBag[i].GetWeight() > deltaWeight)
                    removedWeight += deltaWeight;
                else
                    removedWeight += pasWithBag[i].GetWeight();
                ((PassangerEconomyСlass)pasWithBag[i]).RemoveBaggage(deltaWeight);
            }

            if (removedWeight < value)
            {
                RemoveOverload(value - removedWeight);
            }

            //Console.WriteLine(GetWeight());
            Console.WriteLine(" REMOVE OVERLOAD");
        }
    }
}
