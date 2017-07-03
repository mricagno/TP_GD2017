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
        public decimal ValorKm { get; set; }
        public decimal PrecioBase { get; set; }
        public int Habilitado { get; set; }
    }
}
