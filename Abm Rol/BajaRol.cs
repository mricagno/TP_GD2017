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
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
            
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Close();
        }

        private void btnBajaRol_Click(object sender, EventArgs e)
        {
            //eliminar
            MessageBox.Show("Se elimino correctamente el rol", "Baja Rol", MessageBoxButtons.OK);
            new Principal().Show();
            this.Close();
        }
    }
}
