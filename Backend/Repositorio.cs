using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Backend
{
    public static class Repositorio
    {
        public static ObservableCollection<RegistroViaje> todosLosRegistroViajes()
        {
            String queryString = "select * from  [Qa_GD1C2017].[DROP_DATABASE].[REGISTRO_VIAJE]";
            //SqlDataReader reader = ServerStatic.getInstance().query(queryString);
            SqlDataReader reader = new Server().query(queryString);
            reader.Read();
            var todosLosViajes = new ObservableCollection<RegistroViaje>();
            RegistroViaje registroViaje = new RegistroViaje();
            registroViaje.Automovil = reader["id_automovil"].ToString();
            registroViaje.Chofer = reader["id_chofer"].ToString();

            todosLosViajes.Add(registroViaje);
            
            reader.Close();
           
            //MessageBox.Show(registroViaje.IdAuto);
            return todosLosViajes;
        }

        public static void registrarViaje(RegistroViaje registroViaje) {
            //[ID_CHOFER],[ID_AUTOMOVIL],[ID_TURNO],[ID_CLIENTE],[CANT_KM]
            //,[DT_INICIO_VIAJE],[DT_FIN_VIAJE],[PRECIO_VIAJE]
            String query = " insert into [GD1C2017].[DROP_DATABASE].[REGISTRO_VIAJE] values" + 
                "(" + registroViaje.Chofer+","+registroViaje.Automovil+ ","+"12,1,50,NULL,NULL,50)";

            SqlDataReader reader = ServerStatic.getInstance().query(query);
            reader.Close();
        }


        public static  ObservableCollection<ClienteModificar> todosLosClientesAModificar(){
            String queryString = "EXEC  DROP_DATABASE.TODOS_LOS_CLIENTES";
         
            SqlDataReader reader = new Server().query(queryString);
            var clientes = new ObservableCollection<ClienteModificar>();
            
            while (reader.Read())
            {
                var clienteModificar = new ClienteModificar();

                clienteModificar.Username = reader["id_usuario"].ToString();
                clienteModificar.Nombre = reader["nombre"].ToString();
                clienteModificar.Apellido = reader["apellido"].ToString();
                clienteModificar.Documento = reader["num_dni"].ToString();

                clientes.Add(clienteModificar);
            }
            reader.Close();
            return clientes;
        }

        public static void crearCliente(NuevoCliente nuevoCliente)
        {
            
            String query = "EXEC DROP_DATABASE.CREAR_CLIENTE " + nuevoCliente.usuario + ", " + nuevoCliente.nombre + ", " + nuevoCliente.apellido + ", " + 
                nuevoCliente.num_dni + ", " + nuevoCliente.email + ", " + nuevoCliente.telefono + ", " + 
                nuevoCliente.direccion + ", " + nuevoCliente.codigo_postal + ", '" + nuevoCliente.fecha_nacimiento + "'";
            
            new Server().realizarQuery(query);
            
        }
    }
}
