using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Rol;
using UberFrba.Backend;
using UberFrba.Registro_Viajes;
using UberFrba.Turno;

namespace UberFrba
{
    public partial class Principal : Form
    {
        String seleccionarTab;
        
        public Principal(String tab)
        {
            InitializeComponent();
            seleccionarTab = tab;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void irRegistrarViaje_Click(object sender, EventArgs e)
        {
            new RegistroViajesForm().Show();
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (seleccionarTab == Tabs.turnos())
                tblMenu.SelectTab(tabTurnos.Name);
            if (seleccionarTab == Tabs.seguridad())
                tblMenu.SelectTab(tabSeguridad.Name);
            if (seleccionarTab == Tabs.viajes())
                tblMenu.SelectTab(tabViajes.Name);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            new AltaRol().Show();
            this.Close();
        }

        private void btnBajaRol_Click(object sender, EventArgs e)
        {
            
            new BajaRol().Show();
            this.Close();
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            this.Close();
            new ModificarRol().Show();
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            new AltaFuncionalidad().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BajaFuncionalidad().Show();
            this.Close();
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            new AltaTurno().Show();
            this.Close();
        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            new ModificarTurno().Show();
            this.Close();
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            new BajaTurno().Show();
            this.Close();
        }

        

       
    }
}
