using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace prueba_sourcecol
{
    internal class Program
    {
        static void getCharacters()
        {
            WebRequest request = WebRequest.Create("https://rickandmortyapi.com/api/character");

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                dynamic json = JsonConvert.DeserializeObject(responseFromServer);

                foreach (var e in json.results)
                {
                    Console.WriteLine(e.name);
                }

                // limpia
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (WebException err)
            {
                Console.WriteLine("Fallo {0}", err);
            }
        }

        static void Main(string[] args)
        {
            getCharacters();
        }
    }
}
