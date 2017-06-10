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
            nuevoChofer.nombre = txtNombreChofer.Text;
            nuevoChofer.apellido = txtApellidoChofer.Text;
            if (!Utils.IsDigitsOnly(txtDniChofer.Text) || txtDniChofer.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoChofer.num_dni = Convert.ToInt32(txtDniChofer.Text);
            nuevoChofer.email = txtMailChofer.Text;
            Convert.ToInt32(99999999);
            nuevoChofer.telefono = Convert.ToInt32(txtTelefonoChofer.Text);
            nuevoChofer.direccion = txtDireccionChofer.Text;
            nuevoChofer.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-dd hh:mm:ss");


            try
            {
                Repositorio.crearChofer(nuevoChofer);
                MessageBox.Show("El chofer se creo correctamente:", "Alta chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.chofer()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear chofer - Exception :" + ex.ToString(), "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AltaChofer_Load(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();
            foreach (string s in Repositorio.usuariosSinAsignar())
            {
                lstUsuarios.Items.Add(s);
            }
        }
    }
}
