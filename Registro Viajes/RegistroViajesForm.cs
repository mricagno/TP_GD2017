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

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViajesForm : Form
    {

        public Administrador formAnterior;
        public Usuario usuario;

        public RegistroViajesForm(Administrador form, Usuario user)
        {
            this.formAnterior = form;
            this.usuario = user;
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close(); //TODO: ver si aca hay qe cerrar alguna conexion a db
        }

       
    }
}
