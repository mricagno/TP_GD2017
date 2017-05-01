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

        public Administrador formAnterior;
        public Usuario usuario;
        public ObservableCollection<RegistroViaje> todosLosViajes = new ObservableCollection<RegistroViaje>();
        

        public RegistroViajesForm(Administrador form, Usuario user)
        {
            this.formAnterior = form;
            this.usuario = user;
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close(); //TODO: ver si aca hay qe cerrar alguna conexion a db
        }

        private void button2_Click(object sender, EventArgs e)
        {

            actualizarGrilla();
         
        }

        private void RegistroViajesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            RegistroViaje registroViaje = new RegistroViaje();
            registroViaje.Automovil = txtAutomovil.Text;
            registroViaje.Chofer = txtChofer.Text;
            Repositorio.registrarViaje(registroViaje);
            actualizarGrilla();

        }

        private void actualizarGrilla(){
            ObservableCollection<RegistroViaje> viajes = Repositorio.todosLosRegistroViajes();
            GridTodosLosViajes.DataSource = viajes;
            txtChofer.Text = "";
            txtAutomovil.Text = "";
        }


        
       
    }
}
