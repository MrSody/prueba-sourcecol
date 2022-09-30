using System;
using static prueba_sourcecol.Punto2;

namespace prueba_sourcecol
{
    internal class Program
    {

        static void punto2(int number)
        {
            int numberFibonacci = 0;
            Punto2 punto2 = new Punto2();

            Console.WriteLine("punto 2 - ingrese un numero para saber si cumple con fibonacci");
            numberFibonacci = Int32.Parse(Console.ReadLine());
            Console.WriteLine(punto2.isFibonacci(numberFibonacci));
        }

        static void Main(string[] args)
        {

        }
    }
}
