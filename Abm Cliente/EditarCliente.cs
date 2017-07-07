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
        String principal;
        public EditarCliente(String unDni)
        {
            this.dni = unDni;
            InitializeComponent();
            

             try
            {


                DateTime fecha_hoy = Utils.getConfigDateTime();
                dateFechaNacimiento.Value = fecha_hoy;
                var datacliente = Repositorio.datacliente(dni);

                txtApellidoCliente.Text = datacliente.apellido;
                txtNombreCliente.Text = datacliente.nombre;
                txtDniCliente.Text = datacliente.num_dni.ToString();
                txtMailCliente.Text = datacliente.email.ToString();

                txtDireccionCliente.Text = datacliente.direccion;

                dateFechaNacimiento.Value = new DateTime(datacliente.anio, datacliente.mes, datacliente.dia);
                txtTelefonoCliente.Text = datacliente.telefono.ToString();

                if (datacliente.codigo_postal.ToString() == "-1")
                    txtCodigoPostalCliente.Text = "";
                else
                    txtCodigoPostalCliente.Text = datacliente.codigo_postal.ToString();



            }
            catch (Exception ex)
            {

            }
      
           
        }

        public EditarCliente(String unDni, String username)
        {
            
            InitializeComponent();


            try
            {
                principal = "ok";
                DateTime fecha_hoy = Utils.getConfigDateTime();
                dateFechaNacimiento.Value = fecha_hoy;
                NuevoChofer datacliente = Repositorio.data_alta_chofer(username); //lo reutilizo no es lo correcto
                this.dni = datacliente.num_dni.ToString();
                
                

                txtApellidoCliente.Text = datacliente.apellido;
                txtNombreCliente.Text = datacliente.nombre;
                txtDniCliente.Text = datacliente.num_dni.ToString();
                txtMailCliente.Text = datacliente.email.ToString();

                txtDireccionCliente.Text = datacliente.direccion;

                dateFechaNacimiento.Value = new DateTime(datacliente.anio, datacliente.mes, datacliente.dia);
                txtTelefonoCliente.Text = datacliente.telefono.ToString();


                if (datacliente.telefono.ToString() != "0")
                    txtTelefonoCliente.Text = datacliente.telefono.ToString();
                else
                    txtTelefonoCliente.Text = "";


                if (datacliente.cod_postal.ToString() != "-1")
                    txtCodigoPostalCliente.Text = datacliente.cod_postal.ToString();
                else
                    txtCodigoPostalCliente.Text = "";

                
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
            if (String.IsNullOrEmpty(txtDniCliente.Text) || !Utils.IsDigitsOnly(txtDniCliente.Text) )
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
                MessageBox.Show("Debe ingresar un telefono valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            try
            {
                nuevoCliente.telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un telefono valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("La fecha de nacimiento ingresada no es valida", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            



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
            if (principal == "ok")
                new Principal("").Show();
            else
                new ModificarCliente().Show();
           
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
