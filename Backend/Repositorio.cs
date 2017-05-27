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


        public static  ObservableCollection<DtoClienteModificar> todosLosClientesAModificar(){
            String queryString = "EXEC  DROP_DATABASE.SP_TODOS_LOS_CLIENTES";
         
            SqlDataReader reader = new Server().query(queryString);
            var clientes = new ObservableCollection<DtoClienteModificar>();
            
            while (reader.Read())
            {
                var clienteModificar = new DtoClienteModificar();

                //clienteModificar.Username = reader["id_usuario"].ToString();
                clienteModificar.Nombre = reader["nombre"].ToString();
                clienteModificar.Apellido = reader["apellido"].ToString();
                clienteModificar.Documento = reader["num_dni"].ToString();

                clientes.Add(clienteModificar);
            }
            reader.Close();
            return clientes;
        }

        internal static ObservableCollection<DtoModificarChofer> todosLosChoferesAModificar()
        {
            String queryString = "EXEC  DROP_DATABASE.SP_TODOS_LOS_CHOFERES";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoModificarChofer>();

            while (reader.Read())
            {
                var chofer = new DtoModificarChofer();

                //chofer.Username = reader["id_usuario"].ToString();
                chofer.Nombre = reader["nombre"].ToString();
                chofer.Apellido = reader["apellido"].ToString();
                chofer.Documento = reader["num_dni"].ToString();

                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }

        public static void crearCliente(NuevoCliente nuevoCliente)
        {
            
            String query = "EXEC DROP_DATABASE.SP_CREAR_CLIENTE '" + nuevoCliente.usuario + "', '" + nuevoCliente.nombre + "', '" + nuevoCliente.apellido + "', " + 
                nuevoCliente.num_dni + ", '" + nuevoCliente.email + "', " + nuevoCliente.telefono + ", '" + 
                nuevoCliente.direccion + "', " + nuevoCliente.codigo_postal + ", '" + nuevoCliente.fecha_nacimiento + "'";
            
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
            String query = "EXEC DROP_DATABASE.SP_CREAR_CHOFER '" + nuevoChofer.usuario + "', '" + nuevoChofer.nombre + "', '" + nuevoChofer.apellido + "', " +
                 nuevoChofer.num_dni + ", '" + nuevoChofer.email + "', " + nuevoChofer.telefono + ", '" +
                 nuevoChofer.direccion + "', '" + nuevoChofer.fecha_nacimiento + "'";

            new Server().realizarQuery(query);
        }

        internal static string deshabilitarCliente(string dni)
        {
            String query = "EXEC DROP_DATABASE.SP_DESHABILITAR_CLIENTE " + dni;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba deshabilitado un "1"
        }

        internal static string deshabilitarChofer(string dni)
        {
            String query = "EXEC DROP_DATABASE.SP_DESHABILITAR_CHOFER " + dni;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba deshabilitado un "1"
        }

        internal static string habilitarCliente(string dni)
        {
            String query = "EXEC DROP_DATABASE.SP_HABILITAR_CLIENTE " + dni;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba habilitado un "1"
        }

        internal static string habilitarChofer(string dni)
        {
            String query = "EXEC DROP_DATABASE.SP_HABILITAR_CHOFER " + dni;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba habilitado un "1"
        }

        internal static void modificarCliente(String dni, NuevoCliente actualizarCliente)
        {
            String query = "EXEC DROP_DATABASE.SP_EDITAR_CLIENTE " + dni + ", '" + actualizarCliente.nombre + "', '" + actualizarCliente.apellido + "', " +
                actualizarCliente.num_dni + ", '" + actualizarCliente.email + "', " + actualizarCliente.telefono + ", '" +
                actualizarCliente.direccion + "', " + actualizarCliente.codigo_postal + ", '" + actualizarCliente.fecha_nacimiento + "'";

            new Server().realizarQuery(query);
        }

        
     

        internal static void modificarChofer(String dni, NuevoChofer actualizarChofer)
        {
            String query = "EXEC DROP_DATABASE.SP_EDITAR_CHOFER " + dni + ", '" + actualizarChofer.nombre + "', '" + actualizarChofer.apellido + "', " +
                actualizarChofer.num_dni + ", '" + actualizarChofer.email + "', " + actualizarChofer.telefono + ", '" +
                actualizarChofer.direccion + "', '" + actualizarChofer.fecha_nacimiento + "'";

            new Server().realizarQuery(query);
        }



        internal static void modificarTurno(string nombre, DtoTurno turnoDto)
        {
            String query = "EXEC DROP_DATABASE.SP_EDITAR_TURNO '" + nombre + "', '" + turnoDto.Nombre + "', " + turnoDto.HoraInicio + ", " +
               turnoDto.HoraFin + ", " + turnoDto.ValorKm + ", " + turnoDto.PrecioBase + ", " +
               turnoDto.Habilitado;

            new Server().realizarQuery(query);
        }

        internal static void altaTurno(DtoTurno turnoDto)
        {
            String query = "EXEC DROP_DATABASE.SP_CREAR_TURNO '" + turnoDto.Nombre + "', " + turnoDto.HoraInicio + ", " +
               turnoDto.HoraFin + ", " + turnoDto.ValorKm + ", " + turnoDto.PrecioBase + ", " +
               turnoDto.Habilitado;

            new Server().realizarQuery(query);
        }

        internal static void eliminarTurno(string nombreTurno)
        {
            String query = "EXEC DROP_DATABASE.SP_DESHABILITAR_TURNO '" + nombreTurno + "'";
            new Server().realizarQuery(query);
        }

        internal static ObservableCollection<String> turnosHabilitados()
        {
            String query = "EXEC DROP_DATABASE.SP_TURNOS_HABILITADOS ";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["TURNO"].ToString());

            }
            reader.Close();
            return usuarios;
        }

        internal static ObservableCollection<String> todosLosTurnos()
        {
            String query = "EXEC DROP_DATABASE.SP_TURNOS";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["TURNO"].ToString());

            }
            reader.Close();
            return usuarios;
        }

        internal static ObservableCollection<String> todasLasFuncionalidades()
        {
            String query = "EXEC DROP_DATABASE.SP_FUNCIONALIDADES";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["FUNCIONALIDAD"].ToString());

            }
            reader.Close();
            return usuarios;
        }

        internal static void crearRol(string nombreRolNuevo)
        {
            String query = "EXEC DROP_DATABASE.ALTA_ROL '" + nombreRolNuevo + "'";
            new Server().realizarQuery(query);
        }

        internal static void agregarFuncionalidadARol(String nombreRolNuevo, String func)
        {

            String query = "EXEC DROP_DATABASE.ASOCIAR_FUNCIONALIDAD '" + nombreRolNuevo + "', '" + func + "'";
            new Server().realizarQuery(query);
        }

        internal static ObservableCollection<String> todosLosRoles()
        {

            String query = "EXEC DROP_DATABASE.SP_Roles";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["ROL"].ToString());

            }
            reader.Close();
            return usuarios;
        }

        internal static void habilitarRol(string nombreRol)
        {
            String query = "EXEC DROP_DATABASE.HABILITAR_ROL '" + nombreRol + "'";
            new Server().realizarQuery(query);
        }

        internal static void deshabilitarRol(string nombreRol)
        {
            String query = "EXEC DROP_DATABASE.BAJA_ROL '" + nombreRol + "'";
            new Server().realizarQuery(query);
           // return ""; //aca habria qe devolver si ya estaba deshabilitado un "1"
        }

        internal static ObservableCollection<String> todasLasFuncionalidadesDeRol(string rol)
        {
            String query = "EXEC DROP_DATABASE.SP_ROLES_Y_FUNCIONALIDADES '" + rol + "'";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["FUNCIONALIDAD"].ToString());

            }
            reader.Close();
            return usuarios;
        }

        internal static ObservableCollection<String> todosLosRolesHabilitados()
        {
            //TODO IMPORTANTE. ACA TIENEN QUE SER OTRO STORE PROCEDURE QE DEVUELVA SOLO LOS HABILITADOS
            String query = "EXEC DROP_DATABASE.SP_Roles";
            SqlDataReader reader = new Server().query(query);
            var usuarios = new ObservableCollection<String>();

            while (reader.Read())
            {
                usuarios.Add(reader["ROL"].ToString());

            }
            reader.Close();
            return usuarios;
        }
    }
}
