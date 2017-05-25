using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Cliente;
using UberFrba.Abm_Rol;
using UberFrba.Backend;
using UberFrba.Contabilidad;
using UberFrba.Facturacion;
using UberFrba.Listado_Estadistico;
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
            new AltaRegistroViaje().Show();
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
            if(seleccionarTab == Tabs.clientes())
                tblMenu.SelectTab(tabCliente.Name);
            if (seleccionarTab == Tabs.contabilidad())
                tblMenu.SelectTab(tabContabilidad.Name);
            if (seleccionarTab == Tabs.autos())
                tblMenu.SelectTab(tabAutos.Name);
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
            //obsoleto
            new AltaFuncionalidad().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obsoleto
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

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            new MostrarViajes().Show();
            this.Close();
        }

        private void btnConsultarEstadistica_Click(object sender, EventArgs e)
        {
            if (radioButtonMasConsumo.Checked == true){
                new MasConsumo().Show();
                this.Close();
            }else if (radioButtonMasRecaudacion.Checked == true){
                new MasRecaudacion().Show();
                this.Close();
            } else if (radioButtonMismoAuto.Checked == true){
                new MismoAuto().Show();
                this.Close();
            } else if (radioButtonViajeMasLargo.Checked == true){
                new ViajesMasLargos().Show();
                this.Close();
            }else {
                MessageBox.Show("Debe seleccionar una opcion", "Uber", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnRendicionViajes_Click(object sender, EventArgs e)
        {
            new RendicionViajes().Show();
            this.Close();
        }

        private void btnFacturacionClientes_Click(object sender, EventArgs e)
        {
            new FacturacionClientes().Show();
            this.Close();
        }

        private void NuevoCliente_Click(object sender, EventArgs e)
        {
            new AltaCliente().Show();
            this.Close();
        }

        private void ModificarCliente_Click(object sender, EventArgs e)
        {
            new ModificarCliente().Show();
            this.Close();
        }

    }
}
