using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace crudC.models
{
    public class Coche:  Vehiculo
    {
        public int Id {set;get;}
        public int NumeroPuertas {set;get;}

        public void acelerar(){

        Console.WriteLine("Acelerando al 100");
        }

        
    }
}