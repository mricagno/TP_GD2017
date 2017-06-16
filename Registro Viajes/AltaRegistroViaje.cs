using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
       
        public AltaRegistroViaje()
        {
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
            
         
           
            try{
                RegistroViaje registroViaje = new RegistroViaje();

                registroViaje.Chofer = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).DNI;
                registroViaje.Automovil = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).Patente;
                registroViaje.Turno = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).TurnoAuto;
                registroViaje.Cliente = ((DtoClienteHabilitado)cmbCliente.SelectedItem).DNI;
                registroViaje.CantidadKilometros = txtCantidadKm.Text; //mayor a 0 tiene qe ser validarlo!
                registroViaje.FechaFinViaje = dateFechaInicio.Value.ToString("yyyy-MM-dd hh:mm:ss");
                registroViaje.FechaInicioViaje = dateFechaInicio.Value.ToString("yyyy-MM-dd hh:mm:ss");

                
                Repositorio.registrarViaje(registroViaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alta registro Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


           
           
            new Principal(Tabs.viajes()).Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.viajes()).Show();
            this.Close();
        }

        private void AltaRegistroViaje_Load(object sender, EventArgs e)
        {
             ObservableCollection<DtoClienteHabilitado> clientes = Repositorio.todosLosClientesHabilitados();

             cmbCliente.Items.Clear();
             foreach (var c in clientes)
             {
                 cmbCliente.Items.Add(c);
             }


             ObservableCollection<DtoChoferHabilitado> choferes = Repositorio.todosLosChoferesHabilitadosConAutos();

             cmbChoferHabilitado.Items.Clear();

             foreach (var c in choferes)
             {
                 cmbChoferHabilitado.Items.Add(c);
             }
            



        }

        private void cmbChoferHabilitado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtAutomovil.Text = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).Patente;
            
            txtTurno.Text = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).TurnoAuto;
        }
    }
}
