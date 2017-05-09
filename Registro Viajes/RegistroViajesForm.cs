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

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViajesForm : Form
    {

        public Principal formAnterior;
        public Usuario usuario;
        public List<RegistroViaje> todosLosViajes = new List<RegistroViaje>();
        

        public RegistroViajesForm(Principal form)
        {
            this.formAnterior = form;
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close(); //TODO: ver si aca hay qe cerrar alguna conexion a db
        }

        private void button2_Click(object sender, EventArgs e)
        {
             actualizarGrillaViajes();
             reiniciarValores();
        }

        private void RegistroViajesForm_Load(object sender, EventArgs e)
        {
            cargarGrillaViajes();
            reiniciarValores();
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            //agregarValidaciones
            RegistroViaje registroViaje = new RegistroViaje();
            registroViaje.Automovil = txtAutomovil.Text;
            registroViaje.Chofer = txtChofer.Text;
            registroViaje.CantidadKilometros = txtCantidadKm.Text;
            registroViaje.FechaFinViaje = txtFechaFinViaje.Text;
            registroViaje.FechaInicioViaje = txtFechaInicioViaje.Text;

            //Repositorio.registrarViaje(registroViaje);
            RepositorioMock.registrarViaje(registroViaje);
            actualizarGrillaViajes();

        }

        private void actualizarGrillaViajes(){
            //ObservableCollection<RegistroViaje> viajes = Repositorio.todosLosRegistroViajes();
            
            todosLosViajes.Clear();
            todosLosViajes.AddRange( RepositorioMock.todosLosRegistroViajes());
          
            GridTodosLosViajes.DataSource = todosLosViajes;
            GridTodosLosViajes.Update();
            GridTodosLosViajes.Refresh();
            this.reiniciarValores();
        }

        private void cargarGrillaViajes()
        {
            //ObservableCollection<RegistroViaje> viajes = Repositorio.todosLosRegistroViajes();
            List<RegistroViaje> todosLosViajes = RepositorioMock.todosLosRegistroViajes();
           
            GridTodosLosViajes.DataSource = todosLosViajes;
            GridTodosLosViajes.Update();
            GridTodosLosViajes.Refresh();
            
            this.reiniciarValores();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void reiniciarValores()
        {
            txtAutomovil.Text = "";
            txtChofer.Text = "";
            txtFechaFinViaje.Text = "";
            txtFechaInicioViaje.Text = "";
            txtTurno.Text = "";
            txtCantidadKm.Text = "";
        }



        
       
    }
}
