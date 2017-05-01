using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Backend
{
    public static class Repositorio
    {
        public static void todosLosRegistroViajes(){
            String queryString = "select * from  [GD1C2017].[DROP_DATABASE].[REGISTRO_VIAJE]";
            SqlDataReader reader = Server.getInstance().query(queryString);
            reader.Read();

            RegistroViaje registroViaje = new RegistroViaje();
            registroViaje.IdAuto = reader["id_automovil"].ToString();
         
            reader.Close();

            MessageBox.Show(registroViaje.IdAuto);
        }
    }
}
