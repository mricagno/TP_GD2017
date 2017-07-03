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
            try
            {
                DateTime fecha_hoy = Utils.getConfigDateTime();
                dateFechaNacimiento.Value = fecha_hoy;

            }
            catch (Exception ex)
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dataChofer = Repositorio.data_alta_cliente(lstUsuarios.SelectedItem.ToString());
                txtApellidoCliente.Text = dataChofer.apellido;
                txtDireccionCliente.Text = dataChofer.direccion;

                txtNombreCliente.Text = dataChofer.nombre;
                if (dataChofer.telefono.ToString() != "0")
                    txtTelefonoCliente.Text = dataChofer.telefono.ToString();
                else
                    txtTelefonoCliente.Text = "";

                if (dataChofer.num_dni.ToString() != "0")
                    txtDniCliente.Text = dataChofer.num_dni.ToString();
                else
                    txtDniCliente.Text = "";
                
                
                if(dataChofer.anio.ToString() !=  "0")
                    dateFechaNacimiento.Value = new DateTime(dataChofer.anio, dataChofer.mes, dataChofer.dia);
                else
                    dateFechaNacimiento.Value = Utils.getConfigDateTime();


                txtMailCliente.Text = dataChofer.email;
                if (dataChofer.codigo_postal.ToString() != "0")
                    txtCodigoPostalCliente.Text = dataChofer.codigo_postal.ToString();
                else
                    txtCodigoPostalCliente.Text = "";
                

            }
            catch (Exception ex)
            {

            }
                
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
            if (String.IsNullOrEmpty(txtDniCliente.Text) || !Utils.IsDigitsOnly(txtDniCliente.Text))
            {
                MessageBox.Show("El DNI debe tener digitos numericos", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            
            try
            {
                nuevoCliente.num_dni = Convert.ToInt32(txtDniCliente.Text);
            }
            catch
            {
                MessageBox.Show("El dni ingresado no es valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoCliente.email = "";
            if (!String.IsNullOrEmpty(txtMailCliente.Text))
            {
                if (!txtMailCliente.Text.Contains("@") || !txtMailCliente.Text.Contains(".com"))
                {
                    MessageBox.Show("Debe ingresar un mail valido. Debe contener @ y .com", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                nuevoCliente.email = txtMailCliente.Text;    
            }
            
            if (String.IsNullOrEmpty(txtTelefonoCliente.Text) || !Utils.IsDigitsOnly(txtTelefonoCliente.Text))
            {
                MessageBox.Show("El telefono ingresado no es valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                nuevoCliente.telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            }
            catch
            {
                MessageBox.Show("El telefono ingresado no es valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



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


            try
            {
                nuevoCliente.codigo_postal = Convert.ToInt32(txtCodigoPostalCliente.Text);
            }
            catch
            {
                MessageBox.Show("El codigo postal ingresado no es valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                nuevoCliente.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");
            }
            catch
            {
                MessageBox.Show("La fecha ingresada no es valida", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
           
                

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
