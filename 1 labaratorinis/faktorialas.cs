using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorialas
{
    class fakt
    {
        public int n = 5;  
        public int faktor = 1;   
        public void sudetis2()
        {

            for (int i = 1; i <= n; i++) 
            {
                faktor = faktor * i;
            }
        }
    }
}
