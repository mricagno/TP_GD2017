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

namespace UberFrba
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

      
        public void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nombre = txtUsuario.Text;
            usuario.password = txtPassword.Text;
            usuario.perfil = comboPerfiles.Text;

            Seguridad seguridad = new Seguridad();
            
            if(!seguridad.usuarioTieneAcceso(usuario)){
                MessageBox.Show("Acceso Denegado");
            }
            
            if(comboPerfiles.Text == "Cliente"){
                //this.Hide();
                //new .Inicio_Admin().Show();
            }
            if(comboPerfiles.Text == "Chofer"){
                //this.Hide();
                //new .Inicio_Admin().Show();
            }
            if(comboPerfiles.Text == "Administrador"){
                this.Hide();
                new Administrador(usuario).Show();
            }
            
        }

      
    }
}
