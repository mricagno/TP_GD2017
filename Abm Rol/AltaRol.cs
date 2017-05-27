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
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        

        private void btnGuardarRolYAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            //aca guardo la funcionalidad y le paso al proximo form el nombre de la funcionalidad. Tener un unique de nombre en roles asi puedo buscarlo en el prox form
            String nombreRol = dameNombreRol() ;
           
            Repositorio.crearRol(nombreRol); //TODO METER TRY CATCH CON MENSAJE. Si fallo no continuar


            new AgregarFuncARol(nombreRol, "principal").Show();
            this.Close();

        }

        private string dameNombreRol()
        {
            //TODO IMPORTANTE: QUE NO SEA "" SINO TIRAR UN MENSJAE
            return txtNombreRol.Text;
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal("Turno").Show();
            this.Close();
        }
    }
}
