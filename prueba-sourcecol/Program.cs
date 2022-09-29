using System;

namespace prueba_sourcecol
{
    internal class Program
    {

        static void isFibonacci(int number)
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
                Console.WriteLine("El numero {0} cumple con Fibonacci ", number);
            }
            else
            {
                Console.WriteLine("El numero {0} no cumple con Fibonacci ", number);
            }
        }

        static void Main(string[] args)
        {
            int numberFibonacci = 0;

            Console.WriteLine("punto 2");
            numberFibonacci = Int32.Parse(Console.ReadLine());
            isFibonacci(numberFibonacci);
        }
    }
}
