using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol
{
    public partial class FormEliminarFuncionalidadARol : Form
    {
        public FormEliminarFuncionalidadARol(String nombreRol)
        {
            InitializeComponent();
            //El combo son las funcionalidades que tiene el rol
        }

     

       
        private void btnVolverAModificarRol_Click(object sender, EventArgs e)
        {
            new ModificarRol().Show();
            this.Close();
        }

       
        private void btnEliminarFuncionalidadDeRol_Click(object sender, EventArgs e)
        {
            //Eliminar Rol de funcionalidad
            MessageBox.Show("Se quitó correctamente la funcionalidad", "Modificacion de Rol", MessageBoxButtons.OK);
            new ModificarRol().Show();
            this.Close();
        }

        private void FormEliminarFuncionalidadARol_Load(object sender, EventArgs e)
        {

        }

        
    }
}
