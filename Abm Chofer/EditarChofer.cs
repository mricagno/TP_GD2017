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
            if (!Utils.IsDigitsOnly(txtDniChofer.Text) || txtDniChofer.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos", "Alta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            actualizarChofer.num_dni = Convert.ToInt32(txtDniChofer.Text);
            actualizarChofer.email = txtMailChofer.Text;
            actualizarChofer.telefono = Convert.ToInt32(txtTelefonoChofer.Text);
            actualizarChofer.direccion = txtDireccionChofer.Text;
            actualizarChofer.fecha_nacimiento = dateFechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");


            try
            {
                Repositorio.modificarChofer(this.dni, actualizarChofer);
                MessageBox.Show("El chofer se modifico correctamente:", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.chofer()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar chofer - Exception :" + ex.ToString(), "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
