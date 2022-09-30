using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace prueba_sourcecol
{
    internal class Punto5
    {
        public Punto5()
        {

        }

        public dynamic getCharacters()
        {
            WebRequest request = WebRequest.Create("https://rickandmortyapi.com/api/character");

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                dynamic json = JsonConvert.DeserializeObject(responseFromServer);

                // limpia
                reader.Close();
                dataStream.Close();
                response.Close();

                return json;
            }
            catch (WebException err)
            {
                return "Fallo "+ err;
            }
        }
    }
}
