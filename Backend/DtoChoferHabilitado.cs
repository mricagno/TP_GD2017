using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class DtoChoferHabilitado : Object
    {
        public String usuario;
        public String Patente;
        public String TurnoAuto;
        public int DNI;

     


        public override string ToString()
        {
            return usuario;
        }
    }
}
