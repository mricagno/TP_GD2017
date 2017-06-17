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
    public partial class EditarAuto : Form
    {
        String lapatente;
        public EditarAuto(String unapatente)
        {
            lapatente = unapatente;
         
            InitializeComponent();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMarcas.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un marca", "Alta Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String marca = cmbMarcas.SelectedItem.ToString();
                if (String.IsNullOrEmpty(txtModelo.Text))
                {
                    MessageBox.Show("Debe ingresar modelo", "Alta Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String modelo = txtModelo.Text;
                if (String.IsNullOrEmpty(txtPatente.Text))
                {
                    MessageBox.Show("Debe ingresar patente", "Alta Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String patente = txtPatente.Text;
                if (cmbTurnos.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un turno", "Alta Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String turno = cmbTurnos.SelectedItem.ToString();




                Repositorio.modificarAuto(this.lapatente, marca, modelo, patente, turno);
                MessageBox.Show("El auto se modifico correctamente", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.autos()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void EditarAuto_Load(object sender, EventArgs e)
        {
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
            txtPatente.Text = this.lapatente;
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.autos()).Show();
            this.Close();
        }
    }
}
