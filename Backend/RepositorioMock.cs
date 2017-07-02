using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Backend
{
    public static class RepositorioMock
    {

        public static List<RegistroViaje> todosLosViajes;

        public static List<RegistroViaje> todosLosRegistroViajes(){
           
            if(todosLosViajes == null){
                todosLosViajes = new List<RegistroViaje>();
                RegistroViaje registroViaje = new RegistroViaje();
                registroViaje.Automovil = "auto 1";
                //registroViaje.Chofer = "chofer 1";
                //registroViaje.Cliente = "cliente 1";
               // registroViaje.FechaFinViaje = "fecha 1";
                //registroViaje.FechaInicioViaje = "fecha 1";
                registroViaje.Km = "132312";
                registroViaje.Turno = "turno";
                todosLosViajes.Add(registroViaje);
            }

            return todosLosViajes;
        }

         public static void registrarViaje(RegistroViaje registroViaje) {
             todosLosViajes.Add(registroViaje);
         }

         public static void modificarViaje(RegistroViaje registroViaje)
         {
             //
         }
         public static void eliminarViaje(RegistroViaje registroViaje)
         {
             todosLosViajes.Remove(registroViaje);
         }
    }


}
