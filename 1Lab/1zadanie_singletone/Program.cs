using System;

namespace _1zadanie_singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();
            Console.WriteLine(singleton.GetHashCode());

            Singleton singleton2 = Singleton.getInstance();
            Console.WriteLine(singleton2.GetHashCode());
        }
    }
}
