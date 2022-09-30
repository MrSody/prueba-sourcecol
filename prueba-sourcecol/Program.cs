using System;
using System.Linq;

namespace prueba_sourcecol
{
    internal class Program
    {
        static int[] numberOrder(int[] arrayNumber)
        {
            int countPares = 0;
            string listNumber = "";

            Array.Sort(arrayNumber);
            Array.Reverse(arrayNumber);

            foreach (int dato in arrayNumber)
            {
                if (dato % 2 == 0)
                {
                    countPares++;
                }

                listNumber += dato.ToString() + " ";
            }

            Console.WriteLine("cantidad de pares {0}", countPares);

            Console.WriteLine("Lista de numeros: {0}", listNumber);

            return arrayNumber;
        }

        static int[] createArrayNumber(string datos)
        {
            string[] textNumber;
            int[] arrayNumber = new int[] { };


            textNumber = datos.Split(' ');

            foreach (string data in textNumber)
            {
                int numero = Int32.Parse(data);
                var temp = arrayNumber.ToList();
                temp.Add(numero);

                arrayNumber = temp.ToArray();
            }

            return arrayNumber;
        }

        static void Main(string[] args)
        {
            int[] arrayNumber = new int[] { };

            Console.WriteLine("ingrese numeros con espacios");

            string dato = Console.ReadLine();
            arrayNumber = createArrayNumber(dato);

            numberOrder(arrayNumber);

        }
    }
}
