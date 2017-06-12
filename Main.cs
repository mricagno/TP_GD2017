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
using System.Collections.ObjectModel;

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
            
            //if(!seguridad.usuarioTieneAcceso()){
               // MessageBox.Show("Acceso Denegado");
            //}

            //Si el rol esta seleccionado, se llama a principal
            if (usuario.perfil.Any())
            {
                usuario.perfil = this.comboPerfiles.GetItemText(this.comboPerfiles.SelectedItem);
                Sesion.rol = usuario.perfil;
                new Principal("Seguridad").Show();
                this.Close();
            }

            //HABILITO COMBO DE ROLES
            ObservableCollection<String> roles = seguridad.usuarioTieneAcceso(usuario);
            if (roles.Count() != 0)
            {
                this.comboPerfiles.Visible = true;
            
                this.comboPerfiles.Items.Clear();
                foreach (var m in roles)
                {
                    this.comboPerfiles.Items.Add(m);
                }
                Sesion.username = usuario.nombre;
            }
            //new Principal("Seguridad").Show();
        }
            
    }
}
