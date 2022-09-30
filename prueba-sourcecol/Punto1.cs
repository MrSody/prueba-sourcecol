using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_sourcecol
{
    internal class Punto1
    {
        string textShort;

        public Punto1()
        {
            this.textShort = "";
        }

        public string getTextShort(string textFull)
        {
            if (textFull.Length > 20)
            {
                string[] textList = textFull.Split(' ');

                int countCharacters = 0;

                do
                {
                    foreach (string data in textList)
                    {
                        countCharacters += data.Length;

                        if (countCharacters < 20)
                        {
                            this.textShort += data + " ";
                        }
                        else
                        {
                            if ((countCharacters - 20) == 0)
                            {
                                this.textShort += data + " ";
                            }
                            else
                            {
                                this.textShort += data.Substring(0, (data.Length - (countCharacters - 20)));
                                this.textShort += "...";
                            }
                            break;
                        }
                        countCharacters++;
                    }

                } while (countCharacters < 20);

            }
            else
            {
                return textFull;
            }

            return this.textShort;
        }

    }
}
