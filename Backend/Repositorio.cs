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
            String queryString = "EXEC  DROP_DATABASE.SP_TODOS_LOS_CLIENTES";
         
            SqlDataReader reader = new Server().query(queryString);
            var clientes = new ObservableCollection<ClienteModificar>();
            
            while (reader.Read())
            {
                var clienteModificar = new ClienteModificar();

                //clienteModificar.Username = reader["id_usuario"].ToString();
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
            
            String query = "EXEC DROP_DATABASE.SP_CREAR_CLIENTE " + nuevoCliente.usuario + ", " + nuevoCliente.nombre + ", " + nuevoCliente.apellido + ", " + 
                nuevoCliente.num_dni + ", " + nuevoCliente.email + ", " + nuevoCliente.telefono + ", " + 
                nuevoCliente.direccion + ", " + nuevoCliente.codigo_postal + ", '" + nuevoCliente.fecha_nacimiento + "'";
            
            new Server().realizarQuery(query);
            
        }

        public static ObservableCollection<String> usuariosSinAsignar()
        {
            String query = "EXEC [DROP_DATABASE].[SP_USUARIOS_SIN_ASIGNAR] ";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["usuario"].ToString());
               
            }
            reader.Close();
            return usuarios;
        }

        internal static void crearChofer(NuevoChofer nuevoChofer)
        {
            String query = "EXEC DROP_DATABASE.SP_CREAR_CHOFER " + nuevoChofer.usuario + ", " + nuevoChofer.nombre + ", " + nuevoChofer.apellido + ", " +
                 nuevoChofer.num_dni + ", " + nuevoChofer.email + ", " + nuevoChofer.telefono + ", " +
                 nuevoChofer.direccion + ", '" + nuevoChofer.fecha_nacimiento + "'";

            new Server().realizarQuery(query);
        }

        internal static string deshabilitarCliente(string dni)
        {
            String query = "EXEC DROP_DATABASE.SP_DESHABILITAR_CLIENTE " + dni;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba deshabilitado un "1"
        }

        internal static string habilitarCliente(string dni)
        {
            String query = "EXEC DROP_DATABASE.SP_HABILITAR_CLIENTE " + dni;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba habilitado un "1"
        }

        internal static void modificarCliente(String dni, NuevoCliente actualizarCliente)
        {
            String query = "EXEC DROP_DATABASE.SP_EDITAR_CLIENTE " + dni + ", " + actualizarCliente.nombre + ", " + actualizarCliente.apellido + ", " +
                actualizarCliente.num_dni + ", " + actualizarCliente.email + ", " + actualizarCliente.telefono + ", " +
                actualizarCliente.direccion + ", " + actualizarCliente.codigo_postal + ", '" + actualizarCliente.fecha_nacimiento + "'";

            new Server().realizarQuery(query);
        }

        internal static void modificarChofer(String dni, NuevoChofer actualizarChofer)
        {
            String query = "EXEC DROP_DATABASE.SP_CHOFER_CLIENTE " + dni + ", " + actualizarChofer.nombre + ", " + actualizarChofer.apellido + ", " +
                actualizarChofer.num_dni + ", " + actualizarChofer.email + ", " + actualizarChofer.telefono + ", " +
                actualizarChofer.direccion + ", '" + actualizarChofer.fecha_nacimiento + "'";

            new Server().realizarQuery(query);
        }
    }
}
