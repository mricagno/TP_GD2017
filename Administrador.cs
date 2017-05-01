using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Backend;
using UberFrba.Registro_Viajes;

namespace UberFrba
{
    public partial class Administrador : Form
    {
        public Usuario usuario;

        public Administrador(Usuario user)
        {
            this.usuario = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void irRegistrarViaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistroViajesForm(this, usuario).Show();
        }

       
    }
}
