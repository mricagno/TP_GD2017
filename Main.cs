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


            try
            {
                Usuario usuario = new Usuario();
                usuario.nombre = txtUsuario.Text;
                usuario.password = txtPassword.Text;
                usuario.perfil = comboPerfiles.Text;

                Seguridad seguridad = new Seguridad();

                if (String.IsNullOrEmpty(usuario.nombre) || String.IsNullOrEmpty(usuario.password))
                {
                     MessageBox.Show("Debe ingresar usuario y contraseña",  "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      return;
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

                    botonIniciarSesion.Visible = false;
                    lbliniciarComo.Visible = true;
                    btnIngresar.Visible = true;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;

                } //sino mostrar un mensaje
                //new Principal("Seguridad").Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                //Si el rol esta seleccionado, se llama a principal
                Usuario usuario = new Usuario();
                usuario.nombre = txtUsuario.Text;
                usuario.password = txtPassword.Text;
                usuario.perfil = comboPerfiles.Text;
                if (usuario.perfil.Any())
                {
                    usuario.perfil = this.comboPerfiles.GetItemText(this.comboPerfiles.SelectedItem);
                    Sesion.rol = usuario.perfil;
                    new Principal("").Show();
                    this.Close();
            }

           
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
            
    }
}
