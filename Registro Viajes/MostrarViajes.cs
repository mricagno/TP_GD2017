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
    public partial class MostrarViajes : Form
    {

        public Principal formAnterior;
        public Usuario usuario;
       // public List<RegistroViaje> todosLosViajes = new List<RegistroViaje>();
        

        public MostrarViajes()
        {
            
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.viajes()).Show() ;
            this.Close(); //TODO: ver si aca hay qe cerrar alguna conexion a db
        }

        private void button2_Click(object sender, EventArgs e)
        {
             actualizarGrillaViajes();
            
        }

        private void RegistroViajesForm_Load(object sender, EventArgs e)
        {
            actualizarGrillaViajes();
        }

        private void actualizarGrillaViajes(){
            //ObservableCollection<RegistroViaje> viajes = Repositorio.todosLosRegistroViajes();
            List<RegistroViaje> viajes = RepositorioMock.todosLosRegistroViajes();
            
            
            GridTodosLosViajes.DataSource = viajes;
            GridTodosLosViajes.Update();
            GridTodosLosViajes.Refresh();
           
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            new AltaRegistroViaje().Show();
            this.Close();
        }

        

        
    }
}
