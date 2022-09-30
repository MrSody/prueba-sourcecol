using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_sourcecol
{
    internal class Punto2
    {
        public Punto2()
        {

        }

        public string isFibonacci(int number)
        {
            int number1 = 0;
            int number2 = 1;
            bool cumple = false;

            for (int i = 0; i < number; i++)
            {
                int temp = number1;

                number1 = number2;

                number2 = temp + number1;

                if (number1 == number)
                {
                    cumple = true;
                }
            }

            if (cumple)
            {
                return "El numero "+ number + " cumple con Fibonacci";
            }
            else
            {
                return "El numero "+ number + " no cumple con Fibonacci";
            }
        }
    }
}
