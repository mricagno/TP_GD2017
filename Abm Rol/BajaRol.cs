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
            if(String.IsNullOrEmpty(nombreRol))
            {
               
                MessageBox.Show("Debe seleccionar un rol", "Baja Rol", MessageBoxButtons.OK);
                return;
            }
           
            try
            {
                Repositorio.deshabilitarRol(nombreRol);
                MessageBox.Show("Se elimino correctamente el rol", "Baja Rol", MessageBoxButtons.OK);
                new Principal(Tabs.seguridad()).Show();
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString(), "Baja Rol", MessageBoxButtons.OK);
            }
           

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
           
            return nombreRol;
        }
    }
}
