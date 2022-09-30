using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_sourcecol
{
    internal class Punto3
    {
        int countPares = 0;
        string listNumber = "";
        int[] arrayNumber;

        public Punto3(int[] arrayNumber)
        {
            this.arrayNumber = arrayNumber;
        }

        public int[] numberShort()
        {
            Array.Sort(this.arrayNumber);
            Array.Reverse(this.arrayNumber);

            return this.arrayNumber;
        }

        public int getCountPares()
        {
            foreach (int dato in this.arrayNumber)
            {
                if (dato % 2 == 0)
                {
                    this.countPares++;
                }
            }

            return this.countPares;
        }
    }
}
