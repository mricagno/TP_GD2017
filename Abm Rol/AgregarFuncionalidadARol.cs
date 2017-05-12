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
    public partial class AgregarFuncionalidadARol : Form
    {
        String formAVolver;
        public AgregarFuncionalidadARol(String nombreRol, String dondeVolver)
        {
            InitializeComponent();
            formAVolver = dondeVolver;
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            //agregarFuncioanlidad
            MessageBox.Show("La funcionalidad se agregó correctamente", "Uber", MessageBoxButtons.OK);
            //Sino mostrar otro mensaje
        }

        private void AgregarRolAFuncionalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnFinalizarAgregadoDeFuncionalidades_Click(object sender, EventArgs e)
        {
            if (formAVolver == "principal")
                new Principal().Show();
            else if (formAVolver == "modificarRol")
                new ModificarRol().Show();
            else
                new Principal().Show();
            this.Close();
        }
    }
}
