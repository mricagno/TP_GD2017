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
    public partial class AgregarFuncARol : Form
    {

        String nombreRolNuevo;
        String formAVolver;
        Boolean esModificacion;
        public AgregarFuncARol(String nombreRol, String dondeVolver)
        {
            InitializeComponent();
            formAVolver = dondeVolver;
            nombreRolNuevo = nombreRol;
            esModificacion = false;

        }

        public AgregarFuncARol(String nombreRol, String dondeVolver, Boolean modificar)
        {
            InitializeComponent();
            formAVolver = dondeVolver;
            nombreRolNuevo = nombreRol;
            esModificacion = modificar;

        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            //agregarFuncioanlidad
            MessageBox.Show("La funcionalidad se agregó correctamente", "Uber", MessageBoxButtons.OK);
            //Sino mostrar otro mensaje
        }

        private void AgregarFuncARol_Load(object sender, EventArgs e)
        {
            lstAgregarFuncionalidades.Items.Clear();
            lstFuncionalidades.Items.Clear();

            if(esModificacion)
            {
                foreach (string s in Repositorio.todasLasFuncionalidades())
                {
                    lstFuncionalidades.Items.Add(s);
                }

                foreach (string s in Repositorio.todasLasFuncionalidadesDeRol(nombreRolNuevo))
                {
                    lstAgregarFuncionalidades.Items.Add(s);
                }

            }
            else
            {
                foreach (string s in Repositorio.todasLasFuncionalidades())
                {
                    lstFuncionalidades.Items.Add(s);
                }
            }
           
        }

        private void btnFinalizarAgregadoDeFuncionalidades_Click(object sender, EventArgs e)
        {
            if (formAVolver == "principal")
                new Principal(Tabs.seguridad()).Show();
            else if (formAVolver == "modificarRol")
                new ModificarRol().Show();
            else
                new Principal(Tabs.seguridad()).Show();
            this.Close();
        }

        private void btnFinalizarAgregadoDeFuncionalidades_Click_1(object sender, EventArgs e)
        {
           

            if(lstAgregarFuncionalidades.Items.Count <= 0)
            {
                //TODO agregar mensaje qe tiene qe tener al menos una func
                MessageBox.Show("El rol debe tener al menos una funcionalidad", "Agregar funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(esModificacion)
            {
                Repositorio.eliminarTodasFuncionalidadesDeRol(nombreRolNuevo);
                
            }
             

            //TODO analizar como hacer try catch y rollback por si rompe algun store procedure
            foreach (var funcionalidad in lstAgregarFuncionalidades.Items)
            {
                Repositorio.agregarFuncionalidadARol(nombreRolNuevo, funcionalidad.ToString());
            }

            if(esModificacion)
                MessageBox.Show("modificacion ok", "Uber", MessageBoxButtons.OK);
            else
                MessageBox.Show("se agregaron las func al nuevo rol", "Uber", MessageBoxButtons.OK);
        }

        private void btnAgregarFuncionalidad_Click_1(object sender, EventArgs e)
        {
            if (lstFuncionalidades.SelectedItem == null)
                return;

            if (lstAgregarFuncionalidades.Items.Contains(lstFuncionalidades.SelectedItem.ToString()))
                return;
            lstAgregarFuncionalidades.Items.Add(lstFuncionalidades.SelectedItem.ToString());
        }

        private void btnSacarFuncionalidad_Click(object sender, EventArgs e)
        {
            if (lstAgregarFuncionalidades.SelectedItem == null)
                return;


            lstAgregarFuncionalidades.Items.Remove(lstAgregarFuncionalidades.SelectedItem.ToString());
        }
    }
}
