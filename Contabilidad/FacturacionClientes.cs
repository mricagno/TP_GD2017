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

namespace UberFrba.Contabilidad
{
    public partial class FacturacionClientes : Form
    {
        public FacturacionClientes()
        {
            InitializeComponent();
        }

        private void FacturacionClientes_Load(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();
            ObservableCollection<DtoClienteHabilitado> clientes = Repositorio.todosLosClientesHabilitados();

            foreach (var c in clientes)
            {
                lstClientes.Items.Add(c);
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.contabilidad()).Show();
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
              try
            {


                var cliente = ((DtoClienteHabilitado)lstClientes.SelectedItem);
                if (cliente == null)
                {
                    MessageBox.Show("Debe seleccionar un clinete", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 
                String fecha = dateFactura.Value.ToString("yyyy-MM-dd hh:mm:ss");



                Repositorio.facturar(cliente.DNI, fecha);
                MessageBox.Show("La facturacion del cliente se realizo correctamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.contabilidad()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        }
    }
}
