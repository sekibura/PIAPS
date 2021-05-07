using Lab6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    //деканаи
    class DeansOffice : IObserver
    {
        public void Update(Object subject)
        {
            List<AcademicPerformance> academicPerformances = (List<AcademicPerformance>) subject;
            foreach (AcademicPerformance group in academicPerformances)
            {
                if ((DateTime.Now-group.Date).TotalDays>7)
                {
                    NotifyTeachingDepartment(group);
                }
                else
                {
                    Console.WriteLine("\nAll good " + group.GroupName + ".\n Date is " + group.Date.ToString());
                }
            }
            
        }


        private void NotifyTeachingDepartment(AcademicPerformance subject)
        {
            Console.WriteLine("\nTime is over for " + subject.GroupName+".\n Date is "+subject.Date.ToString());
        }

    }
}
