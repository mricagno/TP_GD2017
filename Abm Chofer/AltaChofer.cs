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

namespace UberFrba.Abm_Chofer
{
    public partial class AltaChofer : Form
    {
        public AltaChofer()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.chofer()).Show();
            this.Close();
        }

        private void btnCrearChofer_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var nuevoChofer = new NuevoChofer();
            nuevoChofer.usuario = lstUsuarios.SelectedItem.ToString();

            if (String.IsNullOrEmpty(txtNombreChofer.Text) || String.IsNullOrEmpty(txtNombreChofer.Text))
            {
                MessageBox.Show("Debe ingresar nombre y apellido un usuario", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoChofer.nombre = txtNombreChofer.Text;
            nuevoChofer.apellido = txtApellidoChofer.Text;
            if (String.IsNullOrEmpty(txtDniChofer.Text) || !Utils.IsDigitsOnly(txtDniChofer.Text) || txtDniChofer.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoChofer.num_dni = Convert.ToInt32(txtDniChofer.Text);
            if (String.IsNullOrEmpty(txtDniChofer.Text) )
            {
                MessageBox.Show("Debe ingresar mail", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoChofer.email = txtMailChofer.Text;
            if (String.IsNullOrEmpty(txtTelefonoChofer.Text) || !Utils.IsDigitsOnly(txtTelefonoChofer.Text))
            {
                MessageBox.Show("Debe ingresar un telefono valido", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoChofer.telefono = Convert.ToInt32(txtTelefonoChofer.Text);
            if (String.IsNullOrEmpty(txtDireccionChofer.Text))
            {
                MessageBox.Show("Debe ingresar direccion", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoChofer.direccion = txtDireccionChofer.Text;
            nuevoChofer.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");


            try
            {
                Repositorio.crearChofer(nuevoChofer);
                MessageBox.Show("El chofer se creo correctamente:", "Alta chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.chofer()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AltaChofer_Load(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();
            //foreach (string s in Repositorio.usuariosSinAsignarAClientes())
            foreach (string s in Repositorio.usuariosSinAsignarAChoferes())
            {
                lstUsuarios.Items.Add(s);
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
