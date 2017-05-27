using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class DtoClienteHabilitado : Object
    {
        public String Usuario;
        public int DNI;

        public override string ToString()
        {
            return Usuario;
        }
    }
}
