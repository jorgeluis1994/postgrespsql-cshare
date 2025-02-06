using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudC.models;

namespace crudC.service
{
    public interface AcountI
    {
         void pagar(decimal saldo);
    }
}