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

namespace UberFrba.Abm_Automovil
{
    public partial class EditarAuto : Form
    {
        String lapatente;
        
        string marca;
        string modelo;
        string dni;
        string turno;

        DtoChoferHabilitado elchofer;
        public EditarAuto(String unapatente)
        {
            lapatente = unapatente;
         
            InitializeComponent();
        }

        public EditarAuto(string patente, string marca, string modelo, string dni, string turno)
        {
            
            this.lapatente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.dni = dni;
            this.turno = turno;
            this.elchofer = new DtoChoferHabilitado();
            this.elchofer.DNI = Convert.ToInt32(dni);
            this.elchofer.Patente = patente;
            this.elchofer.TurnoAuto = turno;
            
            InitializeComponent();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMarcas.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un marca", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String marca = cmbMarcas.SelectedItem.ToString();
                if (String.IsNullOrEmpty(txtModelo.Text))
                {
                    MessageBox.Show("Debe ingresar modelo", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String modelo = txtModelo.Text;
                if (String.IsNullOrEmpty(txtPatente.Text))
                {
                    MessageBox.Show("Debe ingresar patente", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String patente = txtPatente.Text;
                if (cmbTurnos.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un turno", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String turno = cmbTurnos.SelectedItem.ToString();

                String dniChofer = "";

                if (!String.IsNullOrEmpty(cmbChofer.Text) )
                {
                    bool mensaje = true;
                    foreach(DtoChoferHabilitado c in cmbChofer.Items){
                        if(c.usuario == cmbChofer.Text)
                            mensaje = false;
                    }
                   if(mensaje == true)
                    {
                        MessageBox.Show("Debe seleccionar un item del combo o dejarlo vacio", "Modificar Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                
                
                }

                if (cmbChofer.SelectedItem != null)
                {
                    dniChofer = ((DtoChoferHabilitado)(cmbChofer.SelectedItem)).DNI.ToString();
                }
                




                Repositorio.modificarAuto(this.lapatente, marca, modelo, patente, turno, dniChofer);
                MessageBox.Show("El auto se modifico correctamente", "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.autos()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void EditarAuto_Load(object sender, EventArgs e)
        {
            try {
                txtPatente.Text = this.lapatente;
                txtModelo.Text = this.modelo;
                ObservableCollection<String> marcas = Repositorio.todasLasMarcas();
                foreach (var m in marcas)
                {
                    cmbMarcas.Items.Add(m);
                }

                ObservableCollection<String> turnos = Repositorio.turnosHabilitados();
                foreach (var t in turnos)
                {
                    cmbTurnos.Items.Add(t);
                }


                cmbChofer.Items.Clear();
                ObservableCollection<DtoChoferHabilitado> choferes = Repositorio.todosLosChoferesHabilitadosSinAutos();

                foreach (var c in choferes)
                {
                    cmbChofer.Items.Add(c);
                }




               


                if (!string.IsNullOrEmpty(this.marca))
                {
                    cmbMarcas.SelectedItem = this.marca;
                }
                if (!string.IsNullOrEmpty(this.turno))
                {
                    cmbTurnos.SelectedItem = this.turno;
                }


                elchofer.usuario = Repositorio.usuarioDelChofer(elchofer.DNI);
                cmbChofer.Items.Add(elchofer);
                cmbChofer.SelectedItem = elchofer;
            }
            catch (Exception ex)
            {
              
            }
            
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.autos()).Show();
            this.Close();
        }
    }
}
