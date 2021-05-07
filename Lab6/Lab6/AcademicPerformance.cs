using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class AcademicPerformance
    {
        private static int count = 0;
        public string GroupName { get; private set; }
        public float Value { get; set; }
        public DateTime Date { get; private set; }

        public AcademicPerformance()
        {
            count++;
            GroupName = "PIN-" + count; 
        }
     

        public void SetResults()
        {
            Random random = new Random();
            Value = random.Next(0, 10);
            Date = RandomDate();
        }

        private DateTime RandomDate()
        {
            DateTime dateTime;
            Random random = new Random();
            int a = random.Next(0, 20);
            dateTime = DateTime.Now.AddDays(-a);

            return dateTime;
        }

        
    }
}
