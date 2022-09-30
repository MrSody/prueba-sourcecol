using System;
using System.Linq;
using static prueba_sourcecol.Punto1;

namespace prueba_sourcecol
{
    internal class Program
    {
        static void punto1()
        {
            Punto1 punto1 = new Punto1();

            Console.WriteLine("Punto 1 - Ingrese una cadena de texto");
            string textFull = Console.ReadLine();

            Console.WriteLine(punto1.getTextShort(textFull));
        }

        static void Main(string[] args)
        {


        }
    }
}
