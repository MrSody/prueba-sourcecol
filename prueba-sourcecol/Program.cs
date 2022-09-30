using System;
using System.Collections.Generic;
using static prueba_sourcecol.Car;
using System.Linq;

namespace prueba_sourcecol
{
    static List<Car> carModelMayorCinco(List<Car> listCar)
    {
        int modelMax = 2022;

        var listCarMayorCinco = listCar.Where(x => x.Model >= (modelMax - 5)).ToList();

        foreach (var dato in listCarMayorCinco)
        {
            Console.WriteLine("marca {0}", dato.Brand);
            Console.WriteLine("modelo {0}", dato.Model);
            Console.WriteLine("color {0}", dato.Color);
        }

        return listCar.Where(x => x.Model < (modelMax - 5)).ToList();
    }

    static List<Car> addCars()
    {
        bool addCar = true;
        List<Car> listCar = new List<Car>() { };

        do
        {
            Console.WriteLine("ingrese la marca");
            string brand = Console.ReadLine();

            Console.WriteLine("ingrese el modelo");
            int model = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();

            listCar.Add(
                new Car()
                {
                    Brand = brand,
                    Model = model,
                    Color = color,
                }
            );

            Console.WriteLine("Desea ingresar otro carro Y/N");
            string newCar = Console.ReadLine();

            if (newCar.ToLower() == "n")
            {
                addCar = false;
            }

        } while (addCar);

        return listCar;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCar = new List<Car>() { };

            Console.WriteLine("ingrese los datos del carro");

            listCar = addCars();

            var listNewCars = carModelMayorCinco(listCar);
        }
    }
}
