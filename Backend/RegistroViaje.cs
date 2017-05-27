using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class RegistroViaje : Object
    {
        public String FechaInicioViaje { get; set; }
        public String FechaFinViaje { get; set; }
        public String usuarioChofer { get; set; }
        public String usuarioCliente { get; set; }
        public int Chofer; // dni 
        public int Cliente;//dni
        public String Automovil { get; set; } //patente
        public String Turno  { get; set; } //no puedo modifcar esto
        public String CantidadKilometros { get; set; }
        
        

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
