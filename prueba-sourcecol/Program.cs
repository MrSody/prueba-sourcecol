using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using static prueba_sourcecol.Punto1;
using static prueba_sourcecol.Punto2;
using static prueba_sourcecol.Punto3;
using static prueba_sourcecol.Car;
using static prueba_sourcecol.Punto4;
using Newtonsoft.Json;
using static prueba_sourcecol.Punto5;

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
        
        static void punto1()
        {
            Punto1 punto1 = new Punto1();

            Console.WriteLine("Punto 1 - Ingrese una cadena de texto");
            string textFull = Console.ReadLine();

            Console.WriteLine(punto1.getTextShort(textFull));
        }

    
        static void punto2()
        {
            int numberFibonacci = 0;
            Punto2 punto2 = new Punto2();

            Console.WriteLine("punto 2 - ingrese un numero para saber si cumple con fibonacci");
            numberFibonacci = Int32.Parse(Console.ReadLine());
            Console.WriteLine(punto2.isFibonacci(numberFibonacci));
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
        
        static void punto5()
        {
            Punto5 punto5 = new Punto5();
            
            dynamic characters = punto5.getCharacters();

            Console.WriteLine("punto 5 - Nombre de personajes de Rick & Morty");

            foreach (var character in characters.results)
            {
                Console.WriteLine(character.name);
            }
        }
        
        static void Main(string[] args)
        {

        }
    }
}
