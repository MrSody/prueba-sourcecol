using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using static prueba_sourcecol.Punto5;

namespace prueba_sourcecol
{
    internal class Program
    {
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
