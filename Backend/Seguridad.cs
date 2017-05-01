using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    class Seguridad
    {


        public Boolean usuarioTieneAcceso(Usuario usuario)
        {
            //validar que ninguno sea null.
            //conectarme a db y validar qe tenga permiso para ese perfil
            //y qe user y pass esten ok
            //Si no está habilitado aumentar el contador y en ese caso bloquear
            return true;
        }
    }

}
