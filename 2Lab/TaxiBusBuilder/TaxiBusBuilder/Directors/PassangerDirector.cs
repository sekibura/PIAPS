using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBusBuilder.Builders;

namespace TaxiBusBuilder.Directors
{
    class PassangerDirector
    {
        public PasBuilder Builder { get; set; }

        public Passanger BuildPassanger()
        {
            Builder.CreatePassanger();
            Builder.BuildCategory();
            Builder.BuildName();
            return Builder.GetPassanger();
        }


    }
}
