using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database(3);
            DeansOffice deansOffice = new DeansOffice();

            database.Attach(deansOffice);
            database.NewWeek();
            database.NewWeek();
            database.NewWeek();

        }
    }
}
