using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// los siguientes a refactorizar 
using System.Data.SqlClient;
using UberFrba.Backend;

namespace UberFrba.Abm_Rol
{
    public partial class ModificarNombreRol : Form
    {
        public ModificarNombreRol(String nombreRol)
        {
            InitializeComponent();
            lblNombreRolAModificarNombre.Text = nombreRol;
        }

        private void btnModificarNombreRol_Click(object sender, EventArgs e)
        {
            try
            {
                String queryString = "EXEC DROP_DATABASE.RENOMBRAR_ROL'" + lblNombreRolAModificarNombre.Text + "', '" + this.txtNuevoNombreRol.Text + "'";

                SqlDataReader reader = new Server().query(queryString);
                MessageBox.Show("Se modifico correctamente el nombre del rol", "Modificacion Rol", MessageBoxButtons.OK);
                new ModificarRol().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString(), "Uber", MessageBoxButtons.OK);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ModificarRol().Show();
            this.Close();
        }

        private void txtNuevoNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarNombreRol_Load(object sender, EventArgs e)
        {

        }
    }
}
