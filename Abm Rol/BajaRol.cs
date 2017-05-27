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
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
            
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal("Seguridad").Show();
            this.Close();
        }

        private void btnBajaRol_Click(object sender, EventArgs e)
        {
            String nombreRol = dameRolAModificar();
            //TODO agregar try catch y mensajes
            Repositorio.deshabilitarRol(nombreRol);



            MessageBox.Show("Se elimino correctamente el rol", "Baja Rol", MessageBoxButtons.OK);
            new Principal("Seguridad").Show();
            this.Close();
        }

        private void BajaRol_Load(object sender, EventArgs e)
        {
            cmbRoles.Items.Clear();
            //TODO IMPORTANTE!!! AGREGAR ESTE STORE PROCEDURE. NO FILTRA HABILITADOS NADA MAS
            foreach (string s in Repositorio.todosLosRolesHabilitados())
            {
                cmbRoles.Items.Add(s);
            }
        }


        private String dameRolAModificar()
        {
            String nombreRol = cmbRoles.Text;
            //Validar x las dudas qe exista el rol antes de pasarle el nombre?? Puede no haber seleccionado ninguno

            return nombreRol;
        }
    }
}
