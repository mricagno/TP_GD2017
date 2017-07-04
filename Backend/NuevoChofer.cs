using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class NuevoChofer
    {

        public String usuario;
        public String nombre;
        public String apellido;
        public int num_dni;
        public String email;
        public int telefono;
        public String direccion;
        public String fecha_nacimiento;
        public String cod_postal;

        public int anio { get; set; }

        public int mes { get; set; }

        public int dia { get; set; }
    }
}
