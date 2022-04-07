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
            faktorialas.fakt myObj2 = new faktorialas.fakt();
            myObj.sudetis();
             myObj2.sudetis2();
            Console.WriteLine("Galutinis skaicius : " + myObj.c);
            Console.WriteLine("Elementas : " + myObj.n);
            Console.WriteLine("Faktorialas is 5 yra : " + myObj2.faktor);

            Console.ReadLine();
        }
    }

}

