using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public class DtoTurno
    {
        public String Nombre { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public float ValorKm { get; set; }
        public float PrecioBase { get; set; }
        public int Habilitado { get; set; }
    }
}
