using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudC.models
{
    public class Vehiculo
    {
        public int Id { set; get; }
        public String Marca { private set; get; }

        public String Modelo { set; get; }

        public String Anio { set; get; }
        public int VelocidadMaxima { set; get; }

        public void getInformation()
        {
            Console.WriteLine(Anio + Marca + Modelo);
        }


    }

}