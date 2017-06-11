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
using UberFrba.Abm_Automovil;
using UberFrba.Abm_Chofer;
using UberFrba.Abm_Cliente;
using UberFrba.Abm_Rol;
using UberFrba.Backend;
using UberFrba.Contabilidad;
using UberFrba.Listado_Estadistico;
using UberFrba.Registro_Viajes;
using UberFrba.Rendicion_Viajes;
using UberFrba.Turno;

namespace UberFrba
{
    public partial class Principal : Form
    {
        String seleccionarTab;
        
        public Principal(String tab)
        {
            InitializeComponent();
            this.label1.Text = "BIENVENIDO" + ' ' + Sesion.username.ToUpper();
            seleccionarTab = tab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main displayMainForm = new Main();
            displayMainForm.Show();

            this.Close();
        }

        private void irRegistrarViaje_Click(object sender, EventArgs e)
        {
            new AltaRegistroViaje().Show();
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            /*
            //if (!funcionalidades.Contains("BAJA_AUTO"))
            this.btnModificarAuto.Visible = false; // borrar func de la db
            this.brtIrAutos.Visible = false; // borrar func de la db


            ObservableCollection<String> funcionalidades = Repositorio.funcionalidadesUsuario(Sesion.username);
            if(!funcionalidades.Contains("ALTA_ROL"))
                this.btnAltaRol.Enabled = false;
            
            if(!funcionalidades.Contains("BAJA_ROL"))
                this.btnBajaRol.Enabled = false;
            

            if(!funcionalidades.Contains("MODIFICAR_ROL"))
                this.btnBajaRol.Enabled = false;


             if(!funcionalidades.Contains("ALTA_CHOFER"))
                this.btnNuevoChofer.Enabled = false;


             if(!funcionalidades.Contains("MODIFICAR_CHOFER"))
                this.btnModificarChofer.Enabled = false;


             if (!funcionalidades.Contains("ALTA_CLIENTE"))
                 this.NuevoCliente.Enabled = false;


             if (!funcionalidades.Contains("MODIFICAR_CLIENTE"))
                 this.ModificarCliente.Enabled = false;

  
            if (!funcionalidades.Contains("ALTA_TURNO"))
                 this.btnNuevoTurno.Enabled = false;


            if (!funcionalidades.Contains("MODIFICAR_TURNO"))
                 this.btnModificarTurno.Enabled = false;

            if (!funcionalidades.Contains("BAJA_TURNO"))
                 this.btnEliminarTurno.Enabled = false;
            


            if(!funcionalidades.Contains("ADMIN")){
                this.btnBajaRol.Enabled = false;
                this.btnAltaRol.Enabled = false;
                this.btnModificarRol.Enabled = false;
               
            }

            


           

            if (!funcionalidades.Contains("ALTA_AUTO"))
                this.btnAltaAuto.Enabled = false;

            if (!funcionalidades.Contains("BAJA_AUTO"))
                this.btnBajaAuto.Enabled = false;

          

//BAJA_CHOFER -- borrarla
          
//BAJA_CLIENTE-- borrarla



            /*
            this.irAutosAbm;
            this.btnBajaAuto;
            this.btnBajaAuto;
            this.btnModificarAuto;

            this.btnAltaRol;
            this.btnBajaRol;

            this.btnConsultarEstadistica;

            this.btnFacturacionClientes;

           
            
            this.btnRendicionViajes;
            

            this.irRegistrarViaje;
            this.btnVerViajes
            */



            /*
            this.
           
            btnBajaRol;
                btn



VER_VIAJES
CONSULTAR_ESTADISTICAS



            */
            
            if (seleccionarTab == Tabs.turnos())
                tblMenu.SelectTab(tabTurnos.Name);
            if (seleccionarTab == Tabs.seguridad())
                tblMenu.SelectTab(tabSeguridad.Name);
            if (seleccionarTab == Tabs.viajes())
                tblMenu.SelectTab(tabViajes.Name);
            if(seleccionarTab == Tabs.clientes())
                tblMenu.SelectTab(tabCliente.Name);
            if (seleccionarTab == Tabs.chofer())
                tblMenu.SelectTab(tabChoferes.Name);
            if (seleccionarTab == Tabs.contabilidad())
                tblMenu.SelectTab(tabContabilidad.Name);
            if (seleccionarTab == Tabs.autos())
                tblMenu.SelectTab(tabAutos.Name);
            if (seleccionarTab == Tabs.estadisticas())
                tblMenu.SelectTab(tabEstadisticas.Name);
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
            
            this.Close();
            var form = new MostrarViajes();
            form.Show();
            form.actualizarGrillaViajes();

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
                MessageBox.Show("Debe seleccionar una opción", "Uber", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnRendicionViajes_Click(object sender, EventArgs e)
        {
            new RealizarRendicion().Show();
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

        private void btnNuevoChofer_Click(object sender, EventArgs e)
        {
            new AltaChofer().Show();
            this.Close();
        }

        private void btnModificarChofer_Click(object sender, EventArgs e)
        {
            new UberFrba.Abm_Chofer.ModificarChofer().Show();
            this.Close();
        }

        private void tabChoferes_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            new AltaAuto().Show();
            this.Close();
        }

        private void btnBajaAuto_Click(object sender, EventArgs e)
        {
            new BajaAuto().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
