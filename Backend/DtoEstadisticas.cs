using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class DtoChoferMasRecaudacion
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Usuario { get; set; }
        public String Importe { get; set; }
    }

    public class DtoChoferMayorKm
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Usuario { get; set; }
        public String CantidadKM { get; set; }
    }


    public class DtoClienteMayorConsumo
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Usuario { get; set; }
        public String Importe { get; set; }
    }

    public class DtoMasAutos
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Usuario { get; set; }
        public String Viajes { get; set; }
        public String Patente { get; set; }
    }
}
