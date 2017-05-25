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

namespace UberFrba.Abm_Cliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            //@UsuariosSinAsignar
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.clientes()).Show();
            this.Close();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if(lstUsuarios.SelectedItem == null){
                MessageBox.Show("Debe seleccionar un usuario", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String userName = lstUsuarios.SelectedItem.ToString();
            String nombre = txtNombreCliente.Text;
            String apellido = txtApellidoCliente.Text;
            if (!Utils.IsDigitsOnly(txtDniCliente.Text) || txtDniCliente.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int documento = Convert.ToInt32(txtDniCliente.Text);
            String mail = txtMailCliente.Text;
        }
    }
}
