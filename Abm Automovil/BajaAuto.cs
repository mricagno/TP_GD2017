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
    public partial class BajaAuto : Form
    {
        public BajaAuto()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.autos()).Show();
            this.Close();
        }

        private void BajaAuto_Load(object sender, EventArgs e)
        {
            ObservableCollection<String> patentes = Repositorio.todasLasPatentesDeAutosHabilitados();
            foreach (var m in patentes)
            {
                cmbPatentes.Items.Add(m);
            }
        }

        private void btnBajaAuto_Click(object sender, EventArgs e)
        {
            try
            {
                String patente = this.cmbPatentes.GetItemText(this.cmbPatentes.SelectedItem);
                if (String.IsNullOrEmpty(patente))
                {
                    MessageBox.Show("Debe seleccionar un auto", "Baja auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Repositorio.bajaAuto(patente);
                MessageBox.Show("El auto se elimino correctamente", "Baja auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.autos()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Baja auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
