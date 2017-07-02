using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class RegistroViaje : Object
    {
        public String Inicio { get; set; }
        public String Fin { get; set; }
        public String Chofer { get; set; }
        public String Cliente { get; set; }
        public int idChofer; // dni 
        public int idCliente;//dni
        public String Automovil { get; set; } //patente
        public String Turno  { get; set; } //no puedo modifcar esto
        public String Km { get; set; }
        
        

        public RegistroViaje() { }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            RegistroViaje registro = (RegistroViaje)obj;
            return (this.idChofer == registro.idChofer) && (this.idCliente == registro.idCliente) && (this.Automovil == registro.Automovil); ;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
