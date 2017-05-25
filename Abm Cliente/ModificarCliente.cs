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

namespace UberFrba.Abm_Cliente
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            //username nombre apellido dni
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.clientes()).Show();
            this.Close();
        }
    }
}
