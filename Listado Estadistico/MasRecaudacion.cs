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

namespace UberFrba.Listado_Estadistico
{
    public partial class MasRecaudacion : Form
    {
        public MasRecaudacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MasRecaudacion_Load(object sender, EventArgs e)
        {
            this.cmbTrimestre.Items.Clear();
            this.cmbTrimestre.Items.Add(1);
            this.cmbTrimestre.Items.Add(2);
            this.cmbTrimestre.Items.Add(3);
            this.cmbTrimestre.Items.Add(4);

            this.cmbAnio.Items.Clear();
            
            ObservableCollection<String> anios = Repositorio.todosLosAnios();

            foreach (var c in anios)
            {
                this.cmbAnio.Items.Add(c);
            }


        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.estadisticas()).Show();
            this.Close();

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                var anio = cmbAnio.SelectedItem;
                var trimestre = cmbTrimestre.SelectedItem;
                if (anio == null || anio == "" || trimestre == null || trimestre == "")
                {
                    MessageBox.Show("Debe seleccionar año y trimestre", "Estadistica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ObservableCollection<DtoChoferMasRecaudacion> dto = Repositorio.masRecaudacion(anio.ToString(), trimestre.ToString());
                dataGrid.DataSource = dto;
                dataGrid.Update();
                dataGrid.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Estadisticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            



        }
    }
}
