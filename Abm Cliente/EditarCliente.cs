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
    public partial class EditarCliente : Form
    {
        String dni;
        public EditarCliente(String unDni)
        {
            this.dni = unDni;
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            //Completar los campos para el cliente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var actualizarCliente = new NuevoCliente();

            actualizarCliente.nombre = txtNombreCliente.Text;
            actualizarCliente.apellido = txtApellidoCliente.Text;
            if (!Utils.IsDigitsOnly(txtDniCliente.Text) || txtDniCliente.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            actualizarCliente.num_dni = Convert.ToInt32(txtDniCliente.Text);
            actualizarCliente.email = txtMailCliente.Text;
            actualizarCliente.telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            actualizarCliente.direccion = txtDireccionCliente.Text;
            actualizarCliente.codigo_postal = Convert.ToInt32(txtCodigoPostalCliente.Text);
            actualizarCliente.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-dd hh:mm:ss");


            try
            {
                Repositorio.modificarCliente(this.dni,actualizarCliente);
                MessageBox.Show("El cliente se modifico correctamente:", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.clientes()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModificarCliente().Show();
            this.Close();
        }
    }
}
