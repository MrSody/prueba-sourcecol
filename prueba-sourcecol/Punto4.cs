using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static prueba_sourcecol.Car;

namespace prueba_sourcecol
{
    internal class Punto4
    {
        List<Car> listCar;
        List<Car> listCarMayorCinco;

        public Punto4()
        {
            this.listCar = new List<Car>();
            this.listCarMayorCinco = new ();
        }

        public void addCar(string brand, int model, string color)
        {
            this.listCar.Add(
                new Car()
                {
                    Brand = brand,
                    Model = model,
                    Color = color,
                }
            );
        }

        public string carModelMayorCinco()
        {
            int modelMax = 2022;
            string listCar = "";

            this.listCarMayorCinco = this.listCar.Where(x => x.Model >= (modelMax - 5)).ToList();

            foreach (var dato in this.listCarMayorCinco)
            {
                listCar += "Marca: " + dato.Brand + ", modelo: " + dato.Model + " color: " + dato.Color + "\n";
            }

            return listCar;
        }
    }
}
