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
            try
            {
                DateTime fecha_hoy = Utils.getConfigDateTime();
                dateFechaFin.Value = fecha_hoy;
                dateFechaInicio.Value = fecha_hoy;

            }
            catch (Exception ex)
            {

            }
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

                if(cmbChoferHabilitado.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar el chofer", "Alta registro Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbCliente.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar el cliente", "Alta registro Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrEmpty(txtCantidadKm.Text))
                {
                    MessageBox.Show("Debe seleccionar la cantidad de kilometros", "Alta registro Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dateFechaFin.Value <= dateFechaInicio.Value)
                {
                    MessageBox.Show("La fecha final debe ser posterior a la inicial ", "Alta registro Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                registroViaje.Chofer = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).DNI;
                registroViaje.Automovil = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).Patente;
                registroViaje.Turno = ((DtoChoferHabilitado)cmbChoferHabilitado.SelectedItem).TurnoAuto;
                registroViaje.Cliente = ((DtoClienteHabilitado)cmbCliente.SelectedItem).DNI;
                

               
                try
                {
                    var temp = Convert.ToInt32(txtCantidadKm.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar cantidad de km valido", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                registroViaje.CantidadKilometros = txtCantidadKm.Text;
              

                registroViaje.FechaFinViaje = dateFechaFin.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");
                registroViaje.FechaInicioViaje = dateFechaInicio.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");

                
                Repositorio.registrarViaje(registroViaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alta registro Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Se registro el viaje correctamente", "Viaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
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

        private void txtCantidadKm_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCantidadKm.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtCantidadKm.Text = txtCantidadKm.Text.Remove(txtCantidadKm.Text.Length - 1);
            }
       
        }
    }
}
