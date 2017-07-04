using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
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
            //this.label1.Text = "BIENVENIDO" + ' ' + Sesion.username.ToUpper();
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
            
            try
            {
                String fechaHoy = Utils.getIsoConfigDateTime();
                Repositorio.setearFecha(fechaHoy);

            }catch(Exception exep)
            {
        
            }
            

            ObservableCollection<String> funcionalidades = Repositorio.funcionalidadesUsuario(Sesion.rol);



            tblMenu.TabPages.Clear();

            //Tab perfil
            if (Sesion.rol == "CLIENTE")
            {
                tblMenu.TabPages.Add(tlbPerfil);
            }
            if (Sesion.rol == "CHOFER")
            {
                tblMenu.TabPages.Add(tlbPerfil);
            }


            //TAB seguridad
            if (funcionalidades.Contains("ALTA_ROL"))
                this.btnAltaRol.Enabled = true;
            if (funcionalidades.Contains("BAJA_ROL"))
                this.btnBajaRol.Enabled = true;
            if(funcionalidades.Contains("MODIFICAR_ROL"))
                this.btnModificarRol.Enabled = true;


            if (!this.btnModificarRol.Enabled && !this.btnBajaRol.Enabled && !this.btnAltaRol.Enabled )
                tblMenu.TabPages.Remove(tabSeguridad);
            else
                tblMenu.TabPages.Add(tabSeguridad);


            //TAB CLIENTE

            if (funcionalidades.Contains("ALTA_CLIENTE"))
                NuevoCliente.Enabled = true;
            if (funcionalidades.Contains("BAJA_CLIENTE"))
                ModificarCliente.Enabled = true;
            if (funcionalidades.Contains("MODIFICAR_CLIENTE"))
                ModificarCliente.Enabled = true;

            //TAB CHOFER

            if (funcionalidades.Contains("ALTA_CHOFER"))
                this.btnNuevoChofer.Enabled = true;
            if (funcionalidades.Contains("BAJA_CHOFER"))
            {
           
                this.btnModificarChofer.Enabled = true;
            }
            if (funcionalidades.Contains("MODIFICAR_CHOFER"))
                this.btnModificarChofer.Enabled = true;


            if (!this.btnNuevoChofer.Enabled && !this.btnModificarChofer.Enabled)
                tblMenu.TabPages.Remove(tabChoferes);
            else
                tblMenu.TabPages.Add(tabChoferes);   


            //TAB TURNO
            if (funcionalidades.Contains("ALTA_TURNO"))
                this.btnNuevoTurno.Enabled = true;
            if (funcionalidades.Contains("MODIFICAR_TURNO"))
                 this.btnModificarTurno.Enabled = true;
            if (funcionalidades.Contains("BAJA_TURNO"))
            {
                this.btnEliminarTurno.Enabled = true;
             
            }
            if (!this.btnNuevoTurno.Enabled && !this.btnEliminarTurno.Enabled && !this.btnModificarTurno.Enabled)
                tblMenu.TabPages.Remove(tabTurnos);
            else
                tblMenu.TabPages.Add(tabTurnos);   




            //TAB AUTO
            if (funcionalidades.Contains("ALTA_AUTO"))
                btnAltaAuto.Enabled = true;
            if (funcionalidades.Contains("MODIFICAR_AUTO"))
                btnModificarAuto.Enabled = true;
            if (funcionalidades.Contains("BAJA_AUTO"))
                this.btnBajaAuto.Enabled = true;

            if (!this.btnAltaAuto.Enabled && !this.btnModificarAuto.Enabled && !this.btnBajaAuto.Enabled)
                tblMenu.TabPages.Remove(tabAutos);
            else
                tblMenu.TabPages.Add(tabAutos);   


            //TAB VIAJES

            if (funcionalidades.Contains("VER_VIAJES"))
                this.btnVerViajes.Enabled = true;

            if (funcionalidades.Contains("REGISTRAR_VIAJE"))
                this.irRegistrarViaje.Enabled = true;

            if (!this.btnVerViajes.Enabled && !this.irRegistrarViaje.Enabled)
                tblMenu.TabPages.Remove(tabViajes);
            else
                tblMenu.TabPages.Add(tabViajes);


            //TAB CONTABILIDAD

            if (funcionalidades.Contains("RENDIR_VIAJES"))
                this.btnRendicionViajes.Enabled = true;


            if (funcionalidades.Contains("FACTURAR"))
                this.btnFacturacionClientes.Enabled = true;

           

            if (!this.btnRendicionViajes.Enabled && !this.btnFacturacionClientes.Enabled)
                tblMenu.TabPages.Remove(tabContabilidad);
            else
                tblMenu.TabPages.Add(tabContabilidad);


            //Tab ConsultarEstadisticas
            if (funcionalidades.Contains("CONSULTAR_ESTADISTICAS"))
                this.btnConsultarEstadistica.Enabled = true;

            if (!this.btnConsultarEstadistica.Enabled)
                tblMenu.TabPages.Remove(tabContabilidad);
            else
                tblMenu.TabPages.Add(tabContabilidad);


           
            
            if(funcionalidades.Contains("ADMIN")){
                    this.btnAltaRol.Enabled = true;
                    this.btnModificarRol.Enabled = true;
                    this.btnBajaRol.Enabled = true;
                    this.btnModificarAuto.Enabled = true;
                    this.btnNuevoTurno.Enabled = true;
                    this.btnModificarTurno.Enabled = true;
                    this.btnEliminarTurno.Enabled = true;
                //if (funcionalidades.Contains("VER_AUTOS"))
                // this.btnverautos = true;
                    this.btnAltaAuto.Enabled = true;
                    this.btnBajaAuto.Enabled = true;
                    this.btnVerViajes.Enabled = true;
                    this.btnConsultarEstadistica.Enabled = true;
                    this.btnNuevoChofer.Enabled = true;
                    // this.btnNuevoChofer.Enabled = true;
                    this.btnModificarChofer.Enabled = true;
                    this.NuevoCliente.Enabled = true;
                    this.ModificarCliente.Enabled = true;
                    this.btnFacturacionClientes.Enabled = true;
                    this.btnRendicionViajes.Enabled = true;
                    this.irRegistrarViaje.Enabled = true;
                    tblMenu.TabPages.Clear();
                    tblMenu.TabPages.Add(tabSeguridad);
                    tblMenu.TabPages.Add(tabCliente);
                    tblMenu.TabPages.Add(tabChoferes);
                    tblMenu.TabPages.Add(tabTurnos);
                    tblMenu.TabPages.Add(tabAutos);
                    tblMenu.TabPages.Add(tabViajes);
                    tblMenu.TabPages.Add(tabContabilidad);
                    tblMenu.TabPages.Add(tabEstadisticas);

                    
            }


            try{
                if (seleccionarTab == Tabs.turnos())
                    tblMenu.SelectTab(tabTurnos.Name);
                if (seleccionarTab == Tabs.seguridad())
                    tblMenu.SelectTab(tabSeguridad.Name);
                if (seleccionarTab == Tabs.viajes())
                    tblMenu.SelectTab(tabViajes.Name);
                if (seleccionarTab == Tabs.clientes())
                    tblMenu.SelectTab(tabCliente.Name);
                if (seleccionarTab == Tabs.chofer())
                    tblMenu.SelectTab(tabChoferes.Name);
                if (seleccionarTab == Tabs.contabilidad())
                    tblMenu.SelectTab(tabContabilidad.Name);
                if (seleccionarTab == Tabs.autos())
                    tblMenu.SelectTab(tabAutos.Name);
                if (seleccionarTab == Tabs.estadisticas())
                    tblMenu.SelectTab(tabEstadisticas.Name);
            }catch(Exception ex)
            {

            }

            

            try
            {
                if (tblMenu.TabPages.Count == 0)
                    {
                        MessageBox.Show("Su rol no posee funcionalidades habilitadas. Por favor contactarse con el administrador del sistema ", "Uber", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
            
                    }
            }catch(Exception ex)
            {

            }


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
            Sesion.rol = null;
            Sesion.username = null;
            Main displayMainForm = new Main();
            displayMainForm.Show();
            this.Close();
        }

        private void tabAutos_Click(object sender, EventArgs e)
        {

        }
        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            new ModificarAuto().Show();
            this.Close();
        }

        private void btnEditarMisDatos_Click(object sender, EventArgs e)
        {
            if (Sesion.rol == "CLIENTE")
            {
                new EditarCliente(null, Sesion.username).Show();
                this.Close();
            }
            if (Sesion.rol == "CHOFER")
            {
                new EditarChofer(null, Sesion.username).Show();
                this.Close();
            }
               
        }


    }
}
