using System;
using System.Diagnostics;
using System.Threading;

namespace pirmalab
{
    class Program
    {
        static void Main(string[] args)
        {       
            _1_labaratorinis.uzduotis myObj = new _1_labaratorinis.uzduotis();
            myObj.sudetis();
            Console.WriteLine("Galutinis skaicius : " + myObj.c);
            Console.WriteLine("Elementas : " + myObj.n);

            Console.ReadLine();
        }
    }

}

