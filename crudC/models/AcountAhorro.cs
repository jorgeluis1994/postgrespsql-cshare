using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudC.models
{
    public class AcountAhorro:Acount
    {
        public string Interes{set;get;}

        public override void retirarCajero()
        {
            throw new NotImplementedException();
        }
    }
}