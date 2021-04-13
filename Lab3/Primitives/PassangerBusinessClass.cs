using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Primitives
{
    class PassangerBusinessClass : IFlyableUnit
    {
        private float baggageWeight = 0f;

        public PassangerBusinessClass()
        {
            Random random = new Random();
            baggageWeight = random.Next(5, 35);
        }

        public void AddUnit(IFlyableUnit unit)
        {
            throw new NotImplementedException();
        }

        public float GetWeight()
        {
            return baggageWeight;
        }

        public void RemoveAnyUnit()
        {
            throw new NotImplementedException();
        }
    }
}
