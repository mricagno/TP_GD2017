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
            //if(lstUsuarios.SelectedItem == null){
            //    MessageBox.Show("Debe seleccionar un usuario", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            var nuevoCliente = new NuevoCliente();
            //nuevoCliente.usuario = lstUsuarios.SelectedItem.ToString();
            nuevoCliente.usuario = "ehaydossian";
            nuevoCliente.nombre = txtNombreCliente.Text;
            nuevoCliente.apellido = txtApellidoCliente.Text;
            if (!Utils.IsDigitsOnly(txtDniCliente.Text) || txtDniCliente.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.num_dni = Convert.ToInt32(txtDniCliente.Text);
            nuevoCliente.email = txtMailCliente.Text;
            nuevoCliente.telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            nuevoCliente.direccion = txtDireccionCliente.Text;
            nuevoCliente.codigo_postal = Convert.ToInt32(txtCodigoPostalCliente.Text);
            nuevoCliente.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-dd hh:mm:ss");
                

            try{
                Repositorio.crearCliente(nuevoCliente);
            }catch(Exception ex){
                MessageBox.Show("Error al crear cliente - Exception :" + ex.ToString(), "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
