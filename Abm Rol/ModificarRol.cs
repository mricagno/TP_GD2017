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
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
            //El combo de roles tiene qe tener los eliminados tambien para poder habilitarlos nuevamente
            //cmbRoles.s
        }

        private void btnHabilitarRol_Click(object sender, EventArgs e)
        {
            String nombreRol = dameRolAModificar();
            MessageBox.Show("El rol" + nombreRol + "fue habilitado correctamente", "Modificación de rol", MessageBoxButtons.OK);
            new Principal().Show();
            this.Close();

        }

        private void btnAgregarFuncionalidadARol_Click(object sender, EventArgs e)
        {
            String nombreRol = dameRolAModificar();
            String dondeVolver = "modificarRol";
            new AgregarFuncionalidadARol(nombreRol, dondeVolver).Show(); //Pasarle el rol qe va a modificar
            this.Close();
        }

        private void btnModificarNombreRol_Click(object sender, EventArgs e)
        {

            String nombreRol = dameRolAModificar();
            new ModificarNombreRol(nombreRol).Show();
            this.Close();

        }

        private void btnEliminarFuncionalidadARol_Click(object sender, EventArgs e)
        {
            String nombreRol = dameRolAModificar();
            new FormEliminarFuncionalidadARol(nombreRol).Show();
            this.Close();
        }

        private String dameRolAModificar()
        {
            String nombreRol = cmbRoles.Text;
            //Validar x las dudas qe exista el rol antes de pasarle el nombre?? Puede no haber seleccionado ninguno
            return nombreRol;
        }
    }
}
