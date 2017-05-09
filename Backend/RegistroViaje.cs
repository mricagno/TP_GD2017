using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class RegistroViaje : Object
    {

        public String Chofer { get; set; }// tiene que ser el nombre del chofer
        public String Automovil { get; set; }
        public String Cliente { get; set; }
        public String Turno  { get; set; }
        public String CantidadKilometros { get; set; }
        public String FechaInicioViaje { get; set; }
        public String FechaFinViaje  { get; set; }

        public RegistroViaje() { }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            RegistroViaje registro = (RegistroViaje)obj;
            return (this.Chofer == registro.Chofer) && (this.Cliente == registro.Cliente) && (this.Automovil == registro.Automovil); ;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
