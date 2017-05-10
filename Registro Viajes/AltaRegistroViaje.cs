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

namespace UberFrba.Registro_Viajes
{
    public partial class AltaRegistroViaje : Form
    {
        public Form formAnterior;
        public AltaRegistroViaje(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void viajeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void txtAutomovil_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //agregarValidaciones
            RegistroViaje registroViaje = new RegistroViaje();
            registroViaje.Automovil = txtAutomovil.Text;
            registroViaje.Chofer = txtChofer.Text;
            registroViaje.CantidadKilometros = txtCantidadKm.Text;
            registroViaje.FechaFinViaje = txtFechaFinViaje.Text;
            registroViaje.FechaInicioViaje = txtFechaInicioViaje.Text;

            //Repositorio.registrarViaje(registroViaje);
            RepositorioMock.registrarViaje(registroViaje);
            new RegistroViajesForm().Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
