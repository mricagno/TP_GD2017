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
    public partial class BajaTurno : Form
    {
        public BajaTurno()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cmbTurnos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un turno", "Baja turno", MessageBoxButtons.OK);
                return;
            }

            String nombreTurno = cmbTurnos.SelectedItem.ToString();
            try {
                Repositorio.eliminarTurno(nombreTurno);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            MessageBox.Show("Se elimino el turno correctamente", "Baja turno", MessageBoxButtons.OK);
            new Principal(Tabs.turnos()).Show();
            this.Close();

        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.turnos()).Show();
            this.Close();
        }

        private void BajaTurno_Load(object sender, EventArgs e)
        {
            //TURNOS HABILITADOS
            ObservableCollection<String> turnosHabilitados = Repositorio.turnosHabilitados();
            cmbTurnos.Items.Clear();
            foreach (string t in turnosHabilitados)
            {
                cmbTurnos.Items.Add(t);
            }
        }
    }
}
