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
    public partial class ModificarTurno : Form
    {
        public ModificarTurno()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String unTurno = "un turno";
            new AltaTurno(unTurno, "modificar").Show();
            this.Close();
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.turnos()).Show();
            this.Close();
        }
    }
}
