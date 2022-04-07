using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_labaratorinis
{
    class uzduotis
    {
        public double a = 1; //pirmasis sekos narys
        public double b = 2; //antrasis sekos narys
        public double c;  //trečiasis sekos narys
        public int n = 2; //Kelintas sekos elementas yra skaiciuojamas
        public double riba = Math.Pow(10, 15); //pakelia laipsniu
        public void sudetis()
        {

            while (c <= riba)
            {
                c = a * b;
                a = b;
                b = c;
                n++;
            }
        }
    }
}
