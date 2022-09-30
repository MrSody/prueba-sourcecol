using System;
using System.Collections.Generic;
using static prueba_sourcecol.Car;
using static prueba_sourcecol.Punto4;
using System.Linq;

namespace prueba_sourcecol
{
    internal class Program
    {
        static void punto4()
        {
            bool addCar = true;

            Punto4 punto4 = new Punto4();

            Console.WriteLine("ingrese los datos del carro");

            do
            {
                Console.WriteLine("ingrese la marca");
                string brand = Console.ReadLine();

                Console.WriteLine("ingrese el modelo");
                int model = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el color");
                string color = Console.ReadLine();

                punto4.addCar(brand, model, color);

                Console.WriteLine("Desea ingresar otro carro Y/N");
                string newCar = Console.ReadLine();

                if (newCar.ToLower() != "y")
                {
                    addCar = false;
                }

            } while (addCar);

            // Get autos con modelo de hace 5 años
            Console.WriteLine("Autos cuyo modelo es maximo de hace 5 años");
            Console.WriteLine(punto4.carModelMayorCinco());
        }

        static void Main(string[] args)
        {

        }
    }
}
