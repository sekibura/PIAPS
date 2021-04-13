using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    interface IFlyableUnit
    {
        public float GetWeight();
        public void AddUnit(IFlyableUnit unit);
        public void RemoveAnyUnit();
        
    }
}
