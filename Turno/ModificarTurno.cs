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

namespace UberFrba.Turno
{
    public partial class ModificarTurno : Form
    {
        public ModificarTurno()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbTurnos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un turno", "Baja turno", MessageBoxButtons.OK);
                return;
            }

            String nombreTurno = cmbTurnos.SelectedItem.ToString();
            new AltaTurno(nombreTurno, "modificar").Show();
            this.Close();
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.turnos()).Show();
            this.Close();
        }

        private void ModificarTurno_Load(object sender, EventArgs e)
        {
            ObservableCollection<String> turnos = Repositorio.todosLosTurnos();
            cmbTurnos.Items.Clear();
            foreach (string t in turnos)
            {
                cmbTurnos.Items.Add(t);
            }
            cmbTurnos.Refresh();
        }
    }
}
