using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusBuilder.Builders
{
    abstract class PasBuilder
    {
        protected Passanger passanger;

        public void CreatePassanger()
        {
            passanger = new Passanger();
        }

        public abstract void BuildName();
        public abstract void BuildCategory();
        public abstract void BuildPrice();
        public abstract void BuildAge();
        public abstract void BuildOptions();
        public Passanger GetPassanger()
        {
            return passanger;
        }

        
    }
}
