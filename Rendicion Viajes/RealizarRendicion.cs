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

namespace UberFrba.Rendicion_Viajes
{
    public partial class RealizarRendicion : Form
    {
        public RealizarRendicion()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.contabilidad()).Show();
            this.Close();
        }

        private void RealizarRendicion_Load(object sender, EventArgs e)
        {
            lstChoferes.Items.Clear();
            ObservableCollection<DtoChoferHabilitado> choferes = Repositorio.todosLosChoferesHabilitadosConAutos();

            foreach (var c in choferes)
            {
                lstChoferes.Items.Add(c);
            }
        }

        private void btnRendirViaje_Click(object sender, EventArgs e)
        {
            try
            {


                var chofer = ((DtoChoferHabilitado)lstChoferes.SelectedItem);
                if (chofer == null)
                {
                    MessageBox.Show("Debe seleccionar un chofer", "Rendicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                String fecha = dateRendicion.Value.ToString("yyyy-MM-dd hh:mm:ss");



                Repositorio.rendir(chofer.DNI, fecha);
                MessageBox.Show("La rendicion del chofer se realizo correctamente", "Rendicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.contabilidad()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la rendicion - Exception :" + ex.ToString(), "Rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
    }
}
