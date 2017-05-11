using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Rol;
using UberFrba.Backend;
using UberFrba.Registro_Viajes;

namespace UberFrba
{
    public partial class Principal : Form
    {
      

        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void irRegistrarViaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistroViajesForm().Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AltaRol().Show();

        }

       
    }
}
