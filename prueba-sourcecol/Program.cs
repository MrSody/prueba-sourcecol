using System;
using System.Linq;

namespace prueba_sourcecol
{
    internal class Program
    {

        static string textShort(string textFull)
        {
            string textShort = "";

            if ( textFull.Length > 20 )
            {
                string[] textList = textFull.Split(' ');

                int countCharacters = 0;

                do
                {
                    foreach( string data in textList)
                    {
                        countCharacters += data.Length;

                        if ( countCharacters < 20 )
                        {
                            textShort += data +" ";
                        } else
                        {
                            if ( (countCharacters - 20 ) == 0)
                            {
                                textShort += data + " ";
                            } else
                            {
                                textShort += data.Substring(0, (data.Length - (countCharacters  - 20)));
                                textShort += "...";
                            }
                            break;
                        }
                        countCharacters++;
                    }

                } while (countCharacters < 20);

            } else
            {
                return textFull;
            }

            return textShort;
        }

        static void Main(string[] args)
        {
            string textFullPunt1 = "";

            Console.WriteLine("punto 1");
            textFullPunt1 = Console.ReadLine();

            Console.WriteLine( textShort(textFullPunt1) );

        }
    }
}
