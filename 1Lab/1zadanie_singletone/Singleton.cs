using System;
using System.Collections.Generic;
using System.Text;

namespace _1zadanie_singletone
{
    class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {}

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
