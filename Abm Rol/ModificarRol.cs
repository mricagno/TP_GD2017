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
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
        }

        private void btnHabilitarRol_Click(object sender, EventArgs e)
        {
            String nombreRol = dameRolAModificar();

            //TODO meter 
            Repositorio.habilitarRol(nombreRol);

            MessageBox.Show("El rol" + nombreRol + "fue habilitado correctamente", "Modificación de rol", MessageBoxButtons.OK);
            new Principal(Tabs.seguridad()).Show();
            this.Close();

        }

        private void btnAgregarFuncionalidadARol_Click(object sender, EventArgs e)
        {
            String nombreRol = dameRolAModificar();
            String dondeVolver = "modificarRol";
            new AgregarFuncARol(nombreRol, dondeVolver, true).Show(); //Pasarle el rol qe va a modificar
            this.Close();
        }

        private void btnModificarNombreRol_Click(object sender, EventArgs e)
        {

            String nombreRol = dameRolAModificar();
            if (!string.IsNullOrWhiteSpace(nombreRol))
            {
                new ModificarNombreRol(nombreRol).Show();
                this.Close();
            }else{
                MessageBox.Show("Elija un rol a modificar");
            }

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

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            //El combo de roles tiene qe tener los eliminados tambien para poder habilitarlos nuevamente
            cmbRoles.Items.Clear();
            foreach (string s in Repositorio.todosLosRoles())
            {
                cmbRoles.Items.Add(s);
            }
        }

        private void btnmenu_principal_Click(object sender, EventArgs e)
        {

            //String nombreRol = dameRolAModificar();
            //TODO agregar try catch y mensajes
            //Repositorio.deshabilitarRol(nombreRol);
            new Principal("Seguridad").Show();
            this.Close();

        }
    }
}
