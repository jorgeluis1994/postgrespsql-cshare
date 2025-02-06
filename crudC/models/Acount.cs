using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudC.models
{
    public abstract class Acount 
    {
        public int Id { set; get; }
        public String Titular { set; get; }
        public int NumeroCuenta { set; get; }
        public decimal saldo { private set; get; }
        // La propiedad saldo solo puede ser leída desde fuera (getter público, setter privado)
        public decimal saldoNew { get; private set; } = 23;

        public void depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo = saldo + monto;
            }
        }

        public void retirar(decimal monto)
        {

            if (monto > 0)
            {
                saldo = saldo - monto;

            }
            else{
                Console.WriteLine("monto debe ser mayor a cero");
            }
        }

        public abstract void retirarCajero();
    }
}