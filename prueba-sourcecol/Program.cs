using System;
using System.Linq;
using static prueba_sourcecol.Punto3;

namespace prueba_sourcecol
{
    internal class Program
    {
        static int[] convertTextToArrayInt(string text)
        {
            int[] arrayNumber = new int[] { };

            string[] textNumber = text.Split(' ');

            foreach (string data in textNumber)
            {
                int numero = Int32.Parse(data);
                var temp = arrayNumber.ToList();
                temp.Add(numero);

                arrayNumber = temp.ToArray();
            }

            return arrayNumber;
        }

        static void punto3()
        {
            int[] arrayNumber;

            Console.WriteLine("ingrese numeros con espacios");

            string dato = Console.ReadLine();

            arrayNumber = convertTextToArrayInt(dato);

            Punto3 punto3 = new Punto3(arrayNumber);

            // Get cantidad de pares
            Console.WriteLine("cantidad de pares: {0}", punto3.getCountPares());

            // Get array de numeros ordenados de mayor a menor
            Console.WriteLine("Lista de numeros: {0}", string.Join(" ", punto3.numberShort()));
        }

        static void Main(string[] args)
        {

        }
    }
}
