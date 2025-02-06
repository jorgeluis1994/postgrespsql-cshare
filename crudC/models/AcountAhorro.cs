using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudC.service;

namespace crudC.models
{
    public class AcountAhorro : Acount, AcountI
    {
        public string Interes { set; get; }="Sin interes";

        public override void retirarCajero()
        {
            throw new NotImplementedException();
        }

        public void pagar(decimal saldo)
        {
            try
            {
                if (saldo > 0)
                {
                    Console.WriteLine("Pagando.......");
                    // AcountAhorro acount = new AcountAhorro();
                    depositar(saldo);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}