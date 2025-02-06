using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudC.models
{
    public class User
    {
        public int Id { set; get; }
        public String Name { set; get; }=string.Empty;
        public String LastName { set; get; }=string.Empty;
        public int Age { set; get; }

    }
}