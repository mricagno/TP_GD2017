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

namespace UberFrba.Abm_Rol
{
    public partial class AltaFuncionalidad : Form
    {
        public AltaFuncionalidad()
        {
            InitializeComponent();
        }

        private void btnAltaFuncionalidad_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Recuerde que la funcionalidad debe estar implementada. ¿Está seguro que desea continuar?", "Nueva funcionalidad", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes){
                //guardar funcionalidad
                new Principal(Tabs.seguridad()).Show();
                this.Close();
            }
                
        }

        private void btnVolverAMenu_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.seguridad()).Show();
            this.Close();
        }

    }
}
