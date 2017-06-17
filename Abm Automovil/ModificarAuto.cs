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
    public partial class ModificarAuto : Form
    {
        public ModificarAuto()
        {
            InitializeComponent();
        }

        private void ModificarAuto_Load(object sender, EventArgs e)
        {
            //username nombre apellido dni
            ObservableCollection<DtoAutoHabilitado> autos = Repositorio.todosLosAutosAModificar();

            GridAutomovil.DataSource = autos;
            GridAutomovil.Update();
            GridAutomovil.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.autos()).Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow automovil = Utils.getSelectedRow(GridAutomovil);
            if (automovil == null)
            {
                MessageBox.Show("Debe seleccionar un auto", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DtoAutoHabilitado auto_desa = new DtoAutoHabilitado();
            auto_desa.Marca = automovil.Cells[0].Value.ToString();
            auto_desa.Modelo = automovil.Cells[1].Value.ToString();
            auto_desa.Patente = automovil.Cells[2].Value.ToString();
            auto_desa.DNI = automovil.Cells[3].Value.ToString();
            auto_desa.Turno = automovil.Cells[4].Value.ToString();


            try
            {
                String estabaDeshabilitado = Repositorio.deshabilitarAuto(auto_desa);
                if (estabaDeshabilitado == "1")
                {
                    MessageBox.Show("El auto ya se encontraba deshabilitado", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("El auto se deshabilito correctamente", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.autos()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GridAutomovil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow auto = Utils.getSelectedRow(GridAutomovil);
            if (auto == null)
            {
                MessageBox.Show("Debe seleccionar un auto", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DtoAutoHabilitado auto_habi = new DtoAutoHabilitado();
            auto_habi.Marca = auto.Cells[0].Value.ToString();
            auto_habi.Modelo = auto.Cells[1].Value.ToString();
            auto_habi.Patente = auto.Cells[2].Value.ToString();
            auto_habi.DNI = auto.Cells[3].Value.ToString();
            auto_habi.Turno = auto.Cells[4].Value.ToString();
            try
            {
                String estabaHabilitado = Repositorio.habilitarAuto(auto_habi);
                if (estabaHabilitado == "1")
                {
                    MessageBox.Show("El auto ya se encontraba habilitado", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("El auto se habilito correctamente", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.autos()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow auto = Utils.getSelectedRow(GridAutomovil);
            if (auto == null)
            {
                MessageBox.Show("Debe seleccionar un auto", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String patente = auto.Cells[0].Value.ToString();
            new EditarAuto(patente).Show();
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
         


        BindingSource bs = new BindingSource();
        bs.DataSource = GridAutomovil.DataSource;
        bs.Filter = ( "marca like '%" + marca_Box.Text + "%'");
        GridAutomovil.DataSource = bs;
        //GridAutomovil.Update();
        //GridAutomovil.Refresh();
        }

       
    }
}
