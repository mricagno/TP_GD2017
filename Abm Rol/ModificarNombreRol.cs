using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //modificar rol
            MessageBox.Show("Se modifico correctamente el nombre del rol", "Modificacion Rol", MessageBoxButtons.OK);
            new ModificarRol().Show();
            this.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ModificarRol().Show();
            this.Close();
        }
    }
}
