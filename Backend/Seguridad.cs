using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace UberFrba.Backend
{
    class Seguridad
    {


        public ObservableCollection<String> usuarioTieneAcceso(Usuario usuario)
        {
           
                String queryString = "EXEC  DROP_DATABASE.LOGGIN'" + usuario.nombre + "', '" + usuario.password + "'";

                SqlDataReader reader = new Server().query(queryString);
                var roles = new ObservableCollection<String>();
                while (reader.Read())
                {
                    roles.Add(reader["ROL"].ToString());
                }
                reader.Close();
                if(roles.Count() == 0)
                    MessageBox.Show("El usuario no tiene roles asignados", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return roles;
            
           
            //validar que ninguno sea null.
            //conectarme a db y validar qe tenga permiso
            //Si no está habilitado aumentar el contador y en ese caso bloquear

            //return true;
        }

    }

}
