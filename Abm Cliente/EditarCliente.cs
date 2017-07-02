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
            try
            {
                DateTime fecha_hoy = Utils.getConfigDateTime();
                dateFechaNacimiento.Value = fecha_hoy;

            }
            catch (Exception ex)
            {

            }
           
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            //Completar los campos para el cliente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new NuevoCliente();

            
            if (String.IsNullOrEmpty(txtNombreCliente.Text) || String.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                MessageBox.Show("Debe ingresar nombre y apellido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.nombre = txtNombreCliente.Text;
            nuevoCliente.apellido = txtApellidoCliente.Text;
            if (String.IsNullOrEmpty(txtDniCliente.Text) || !Utils.IsDigitsOnly(txtDniCliente.Text) || txtDniCliente.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            nuevoCliente.num_dni = Convert.ToInt32(txtDniCliente.Text);
            if (String.IsNullOrEmpty(txtMailCliente.Text))
            {
                MessageBox.Show("Debe ingresar un mail", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.email = txtMailCliente.Text;
            if (String.IsNullOrEmpty(txtTelefonoCliente.Text) || !Utils.IsDigitsOnly(txtTelefonoCliente.Text))
            {
                MessageBox.Show("Debe ingresar un telefono valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            if (String.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                MessageBox.Show("Debe ingresar una direccion", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.direccion = txtDireccionCliente.Text;
            if (String.IsNullOrEmpty(txtCodigoPostalCliente.Text) || !Utils.IsDigitsOnly(txtCodigoPostalCliente.Text))
            {
                MessageBox.Show("Debe ingresar codigo postal", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.codigo_postal = Convert.ToInt32(txtCodigoPostalCliente.Text);
            nuevoCliente.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");



            var actualizarCliente = nuevoCliente;

           

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
