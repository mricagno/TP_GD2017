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
    public partial class MismoAuto : Form
    {
        public MismoAuto()
        {
            InitializeComponent();
        }

        private void MismoAuto_Load(object sender, EventArgs e)
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

        private void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                var anio = this.cmbAnio.SelectedItem;
                var trimestre = this.cmbTrimestre.SelectedItem;
                if (anio == null || anio == "" || trimestre == null || trimestre == "")
                {
                    MessageBox.Show("Debe seleccionar año y trimestre", "Estadistica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ObservableCollection<DtoMasAutos> dto = Repositorio.masAutos(anio.ToString(), trimestre.ToString());
                this.dataGrid.DataSource = dto;
                this.dataGrid.Update();
                this.dataGrid.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta" + ex.ToString(), "Estadisticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.estadisticas()).Show();
            this.Close();
        }
    }
}
