using System;
using System.Collections.Generic;
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
            //eliminar turno
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
        
        }
    }
}
