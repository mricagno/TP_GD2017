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
    public partial class EditarChofer : Form
    {
        String dni;
        public EditarChofer( String unDni)
        {
            this.dni = unDni;
            InitializeComponent();

            try
            {
                DateTime fecha_hoy = Utils.getConfigDateTime();
                dateFechaNacimiento.Value = fecha_hoy;
                var dataChofer = Repositorio.dataChofer(dni);
                txtApellidoChofer.Text = dataChofer.apellido;
                txtDireccionChofer.Text = dataChofer.direccion;
                
                txtNombreChofer.Text = dataChofer.nombre;
                txtTelefonoChofer.Text = dataChofer.telefono.ToString();
                txtDniChofer.Text = dataChofer.num_dni.ToString();
                dateFechaNacimiento.Value = new DateTime(dataChofer.anio, dataChofer.mes, dataChofer.dia);

            }
            catch (Exception ex)
            {

            }
        }

        private void EditarChofer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModificarChofer().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var actualizarChofer = new NuevoChofer();

            actualizarChofer.nombre = txtNombreChofer.Text;
            actualizarChofer.apellido = txtApellidoChofer.Text;
            if (!Utils.IsDigitsOnly(txtDniChofer.Text) )
            {
                MessageBox.Show("El DNI debe tener digitos numericos", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                actualizarChofer.num_dni = Convert.ToInt32(txtDniChofer.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un dni valido", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (String.IsNullOrEmpty(txtMailChofer.Text))
            {
                MessageBox.Show("Debe ingresar un mail", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!txtMailChofer.Text.Contains("@") || !txtMailChofer.Text.Contains(".com"))
            {
                MessageBox.Show("Debe ingresar un mail valido. Debe contener @ y .com", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            actualizarChofer.email = txtMailChofer.Text;
            try
            {
                actualizarChofer.telefono = Convert.ToInt32(txtTelefonoChofer.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un telefono valido", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (String.IsNullOrEmpty(txtDireccionChofer.Text))
            {
                MessageBox.Show("Debe ingresar una direccion", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            actualizarChofer.direccion = txtDireccionChofer.Text;
            try
            {
                actualizarChofer.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");
            }
            catch
            {
                MessageBox.Show("Debe ingresar una fecha valido", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            


            try
            {
                Repositorio.modificarChofer(this.dni, actualizarChofer);
                MessageBox.Show("El chofer se modifico correctamente:", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.chofer()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
