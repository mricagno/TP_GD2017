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
            lstUsuarios.Items.Clear();
            foreach(string s in Repositorio.usuariosSinAsignar()) {
                lstUsuarios.Items.Add(s);
            }
            
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
           
            var nuevoCliente = new NuevoCliente();




           

           
            nuevoCliente.usuario = lstUsuarios.SelectedItem.ToString();
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
            nuevoCliente.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-dd hh:mm:ss");
                

            try{
                Repositorio.crearCliente(nuevoCliente);
                MessageBox.Show("El cliente se creo correctamente:", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.clientes()).Show();
                this.Close();

            }catch(Exception ex){
                MessageBox.Show(ex.Message.ToString(), "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
