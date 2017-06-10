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

namespace UberFrba.Abm_Automovil
{
    public partial class AltaAuto : Form
    {
        public AltaAuto()
        {
            InitializeComponent();
        }

        private void AutomovilForm_Load(object sender, EventArgs e)
        {
            lstChoferes.Items.Clear();
            ObservableCollection<DtoChoferHabilitado> choferes = Repositorio.todosLosChoferesHabilitadosSinAutos();

            foreach (var c in choferes)
            {
                lstChoferes.Items.Add(c);
            }

            ObservableCollection<String> marcas = Repositorio.todasLasMarcas();
            foreach (var m in marcas)
            {
                cmbMarcas.Items.Add(m);
            }

            ObservableCollection<String> turnos = Repositorio.turnosHabilitados();
            foreach (var t in turnos)
            {
                cmbTurnos.Items.Add(t);
            }
           
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.autos()).Show();
            this.Close();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
          
            try
            {
                //agregar validaciones
                String marca = cmbMarcas.SelectedItem.ToString();
                String modelo = txtModelo.Text;
                String patente = txtPatente.Text;
                String turno = cmbTurnos.SelectedItem.ToString();
                int DNI = ((DtoChoferHabilitado)lstChoferes.SelectedItem).DNI;



                Repositorio.crearAuto(marca, modelo, patente, DNI, turno);
                MessageBox.Show("El auto se creo correctamente:", "Alta auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.autos()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear auto - Exception :" + ex.ToString(), "Alta auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }
    }
}
