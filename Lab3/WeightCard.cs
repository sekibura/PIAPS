using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class WeightCard
    {
        public float PilotWeight { get; set; }
        public float StewardessWeight { get; set; }
        public float BusinessClassWeight { get; set; }
        public float FirstClassWeight { get; set; }
        public float EconomyClassWeight { get; set; }

        public float GetSummaryWeight() 
        {
            return PilotWeight + StewardessWeight + BusinessClassWeight + FirstClassWeight + EconomyClassWeight;
        }
    }
}
