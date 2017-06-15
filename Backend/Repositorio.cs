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
          
            String queryString = "EXEC  DROP_DATABASE.SP_REGISTROS_DE_VIAJES";

            SqlDataReader reader = new Server().query(queryString);
            var registros = new ObservableCollection<RegistroViaje>();

            while (reader.Read())
            {
                var registroViaje = new RegistroViaje();

           
                registroViaje.usuarioChofer = reader["CHOFER_USUARIO"].ToString();
                registroViaje.usuarioCliente = reader["CLIENTE_USUARIO"].ToString();
                registroViaje.Turno = reader["TURNO"].ToString();
                registroViaje.CantidadKilometros = reader["CANT_KILOMETROS"].ToString();
                registroViaje.Automovil = reader["PATENTE"].ToString();
                registroViaje.FechaInicioViaje = reader["FECHA_INICIO"].ToString();
                registroViaje.FechaFinViaje = reader["FECHA_FIN"].ToString();
                

                registros.Add(registroViaje);
            }
            reader.Close();
            return registros;

        }

        public static ObservableCollection<DtoAutoHabilitado> todosLosAutosAModificar(){

            String queryString = "EXEC  DROP_DATABASE.AUTOS";

            SqlDataReader reader = new Server().query(queryString);
            var autos = new ObservableCollection<DtoAutoHabilitado>();

            while (reader.Read())
            {
                var registroAuto = new DtoAutoHabilitado();


                registroAuto.marca = reader["ID_MARCA"].ToString();
                registroAuto.modelo = reader["MODELO"].ToString();
                registroAuto.patente = reader["PATENTE"].ToString();
                registroAuto.DNI = reader["NUM_DNI"].ToString();
                registroAuto.turno = reader["TURNO"].ToString();

                autos.Add(registroAuto);
            }
            reader.Close();
            return autos;

        }

        public static void registrarViaje(RegistroViaje registroViaje) {

            String query = "EXEC DROP_DATABASE.SP_ALTA_REGISTRO_VIAJE '" + registroViaje.Chofer + "', '" + registroViaje.Automovil + "', '" + registroViaje.Turno + "', " +
                registroViaje.CantidadKilometros + ", '" + registroViaje.FechaInicioViaje + "', '" + registroViaje.FechaFinViaje + "', '" +
                registroViaje.Cliente + "'";

            new Server().realizarQuery(query);

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

        internal static ObservableCollection<DtoModificarChofer> todosLosChoferes()
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

        internal static string habilitarAuto(DtoAutoHabilitado auto)
        {
            String query = "EXEC DROP_DATABASE.SP_HABILITAR_AUTO " + auto.patente + "', '" + auto.DNI + "', '" + auto.turno;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba habilitado un "1"
        }

        internal static string deshabilitarAuto(DtoAutoHabilitado auto)
        {
            String query = "EXEC DROP_DATABASE.BAJA_AUTO " + auto.patente;
            new Server().realizarQuery(query);
            return ""; //aca habria qe devolver si ya estaba deshabilitado un "1"
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
            //new Server().realizarQuery(query);
            try
             {
                new Server().realizarQuery(query);
             }
            catch (SqlException ex)
             {
                 MessageBox.Show(ex.Message);
                 throw new System.ArgumentException();
            } 
        }

        internal static void crearAuto(String marca, String modelo, String patente, int DNI, String turno)
        {

            String query = "EXEC DROP_DATABASE.ALTA_AUTO '" + marca + "', '" + modelo + "' , '" + patente + "' ," + DNI.ToString() + ", '" + turno + "' ";
            new Server().realizarQuery(query);
        }

        internal static void agregarFuncionalidadARol(String nombreRolNuevo, String func)
        {

            String query = "EXEC DROP_DATABASE.ASOCIAR_FUNCIONALIDAD '" + nombreRolNuevo + "', '" + func + "'";
            //new Server().realizarQuery(query);
         try
             {
                 new Server().realizarQuery(query);
             }
         catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
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
            //new Server().realizarQuery(query);
           try
            {
                new Server().realizarQuery(query);
            }
           catch (SqlException ex)
            {
                 MessageBox.Show(ex.Message);
             } 
        }

        internal static void deshabilitarRol(string nombreRol)
        {
            String query = "EXEC DROP_DATABASE.BAJA_ROL '" + nombreRol + "'";
            //new Server().realizarQuery(query);
           try
            {
                new Server().realizarQuery(query);
            }
           catch (SqlException ex)
             {
                MessageBox.Show(ex.Message);
             } 
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

        internal static void eliminarTodasFuncionalidadesDeRol(string nombreRolNuevo)
        {
            String query = "EXEC DROP_DATABASE.ELIMINAR_FUNCIONALIDADES_ROL '" + nombreRolNuevo + "'";
            new Server().realizarQuery(query);
        }

        internal static ObservableCollection<DtoClienteHabilitado> todosLosClientesHabilitados()
        {
            String queryString = "EXEC  DROP_DATABASE.SP_CLIENTES_HABILITADOS";

            SqlDataReader reader = new Server().query(queryString);
            var clientes = new ObservableCollection<DtoClienteHabilitado>();

            while (reader.Read())
            {
                var cliente = new DtoClienteHabilitado();


                cliente.Usuario = reader["USUARIO"].ToString();
                
                cliente.DNI = Convert.ToInt32( reader["NUM_DNI"].ToString());
               
                clientes.Add(cliente);
            }
            reader.Close();
            return clientes;
        }

        internal static ObservableCollection<DtoChoferHabilitado> todosLosChoferesHabilitadosConAutos()
        {
            String queryString = "EXEC  DROP_DATABASE.SP_CHOFERES_HABILITADOS_CON_SUS_AUTOS";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoChoferHabilitado>();

            while (reader.Read())
            {
                var chofer = new DtoChoferHabilitado();

                chofer.usuario = reader["USUARIO"].ToString();
                chofer.Patente = reader["PATENTE"].ToString();
                chofer.TurnoAuto = reader["TURNO"].ToString();
                chofer.DNI = Convert.ToInt32( reader["NUM_DNI"].ToString());
               
                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }


        internal static ObservableCollection<string> todasLasMarcas()
        {
            String queryString = "EXEC  DROP_DATABASE.MARCAS_DE_AUTO";

            SqlDataReader reader = new Server().query(queryString);
            var marcas = new ObservableCollection<String>();

            while (reader.Read())
            {
                marcas.Add(reader["MARCA"].ToString());
            }
            reader.Close();
            return marcas;
        }

        internal static ObservableCollection<DtoChoferHabilitado> todosLosChoferesHabilitadosSinAutos()
        {
            String queryString = "EXEC  DROP_DATABASE.SP_CHOFERES_HABILITADOS_SIN_AUTOS";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoChoferHabilitado>();

            while (reader.Read())
            {
                var chofer = new DtoChoferHabilitado();

                chofer.usuario = reader["USUARIO"].ToString();
                chofer.DNI = Convert.ToInt32(reader["NUM_DNI"].ToString());

                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }

        internal static ObservableCollection<string> todasLasPatentesDeAutosHabilitados()
        {


            String queryString = "EXEC  DROP_DATABASE.SP_PATENTES_HABILITADAS";

            SqlDataReader reader = new Server().query(queryString);
            var patentes = new ObservableCollection<String>();

            while (reader.Read())
            {
               

                patentes.Add(reader["PATENTE"].ToString());
                

            }
            reader.Close();
            return patentes;
        }

        internal static void bajaAuto(string patente)
        {
            String query = "EXEC DROP_DATABASE.[BAJA_AUTO] '" + patente + "'";
            new Server().realizarQuery(query);
        }

        internal static void rendir(int dni, string fecha)
        {
            String query = "EXEC DROP_DATABASE.[SP_RENDIR_VIAJES] " + dni.ToString() + ", '" + fecha + "'";
            new Server().realizarQuery(query);
        }

        internal static void facturar(int dni, string fecha)
        {
            String query = "EXEC DROP_DATABASE.[FACTURAR_MES_CLIENTE] " + dni.ToString() + ", '" + fecha + "'";
            new Server().realizarQuery(query);
        }

        internal static ObservableCollection<String> todosLosAnios()
        {
            String queryString = "EXEC  DROP_DATABASE.SP_ANOS";

            SqlDataReader reader = new Server().query(queryString);
            var anios = new ObservableCollection<String>();

            while (reader.Read())
            {


                anios.Add(reader["ANIO"].ToString());


            }
            reader.Close();
            return anios;
        }

        internal static ObservableCollection<DtoChoferMasRecaudacion> masRecaudacion(String anio, String trimestre)
        {
            String queryString = "EXEC  DROP_DATABASE.SP_CHOFERES_MAYOR_RECAUDACION '" + anio + "', '" + trimestre + "'";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoChoferMasRecaudacion>();

            while (reader.Read())
            {
                var chofer = new DtoChoferMasRecaudacion();

                chofer.Apellido = reader["APELLIDO"].ToString();
                chofer.Nombre = reader["NOMBRE"].ToString();
                chofer.Mail = reader["EMAIL"].ToString();
                chofer.Usuario = reader["USUARIO"].ToString();
                chofer.Importe = reader["IMPORTE"].ToString();
                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }

        internal static ObservableCollection<DtoChoferMayorKm> choferesMayorKm(string anio, string trimestre)
        {
            String queryString = "EXEC  DROP_DATABASE.SP_CHOFERES_MAYOR_KM '" + anio + "', '" + trimestre + "'";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoChoferMayorKm>();

            while (reader.Read())
            {
                var chofer = new DtoChoferMayorKm();

                chofer.Apellido = reader["APELLIDO"].ToString();
                chofer.Nombre = reader["NOMBRE"].ToString();
                chofer.Mail = reader["EMAIL"].ToString();
                chofer.Usuario = reader["USUARIO"].ToString();
                chofer.CantidadKM = reader["CANT_KM"].ToString();
                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }

        internal static ObservableCollection<DtoClienteMayorConsumo> masConsumo(string anio, string trimestre)
        {


            String queryString = "EXEC  DROP_DATABASE.SP_CLIENTE_MAYOR_CONSUMO '" + anio + "', '" + trimestre + "'";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoClienteMayorConsumo>();

            while (reader.Read())
            {
                var chofer = new DtoClienteMayorConsumo();

                chofer.Apellido = reader["APELLIDO"].ToString();
                chofer.Nombre = reader["NOMBRE"].ToString();
                chofer.Mail = reader["EMAIL"].ToString();
                chofer.Usuario = reader["USUARIO"].ToString();
                chofer.Importe = reader["IMPORTE"].ToString();
                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }

        internal static ObservableCollection<DtoMasAutos> masAutos(string anio, string trimestre)
        {
            String queryString = "EXEC  DROP_DATABASE.SP_CLIENTE_MAS_VIAJES_EN_UN_AUTO '" + anio + "', '" + trimestre + "'";

            SqlDataReader reader = new Server().query(queryString);
            var choferes = new ObservableCollection<DtoMasAutos>();

            while (reader.Read())
            {
                var chofer = new DtoMasAutos();

                chofer.Apellido = reader["APELLIDO"].ToString();
                chofer.Nombre = reader["NOMBRE"].ToString();
                chofer.Mail = reader["EMAIL"].ToString();
                chofer.Usuario = reader["USUARIO"].ToString();
                chofer.Viajes = reader["VIAJES"].ToString();
                chofer.Patente = reader["PATENTE"].ToString();
                choferes.Add(chofer);
            }
            reader.Close();
            return choferes;
        }

        internal static ObservableCollection<String> funcionalidadesUsuario(string p)
        {
            String query = "SELECT * FROM DROP_DATABASE.FUNCIONALIDADES_ROL ('" + p + "')";
            SqlDataReader reader = new Server().query(query);
            string funcion;
            var funcionalidades = new ObservableCollection<String>();
            while (reader.Read())
            {
                funcion = reader["FUNCIONALIDAD"].ToString();
                funcionalidades.Add(funcion);
            }
            reader.Close();
            return funcionalidades;
        }
    }
}
