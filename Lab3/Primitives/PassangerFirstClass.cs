using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Primitives
{
    class PassangerFirstClass : IFlyableUnit
    {
        private float baggageWeight = 0f;

        public PassangerFirstClass()
        {
            Random random = new Random();
            baggageWeight = random.Next(5, 60);
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
