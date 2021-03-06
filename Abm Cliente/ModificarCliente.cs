﻿using System;
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
            DataGridViewRow cliente = Utils.getSelectedRow(GridClientes);
            if(cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = cliente.Cells[2].Value.ToString();
           

            try
            {
                String estabaDeshabilitado = Repositorio.deshabilitarCliente(dni);
                if(estabaDeshabilitado == "1"){
                    MessageBox.Show("El cliente ya se encontraba deshabilitado", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("El cliente se deshabilito correctamente", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.clientes()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar cliente - Exception :" + ex.ToString(), "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow cliente = Utils.getSelectedRow(GridClientes);
            if (cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = cliente.Cells[2].Value.ToString();
            new EditarCliente(dni).Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            //username nombre apellido dni
            ObservableCollection<DtoClienteModificar> clientes = Repositorio.todosLosClientesAModificar();


            GridClientes.DataSource = clientes;
            GridClientes.Update();
            GridClientes.Refresh();

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.clientes()).Show();
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow cliente = Utils.getSelectedRow(GridClientes);
            if (cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = cliente.Cells[2].Value.ToString();


            try
            {
                String estabaHabilitado = Repositorio.habilitarCliente(dni);
                if (estabaHabilitado == "1")
                {
                    MessageBox.Show("El cliente ya se encontraba habilitado", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("El cliente se habilito correctamente", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.clientes()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al habilitar cliente - Exception :" + ex.ToString(), "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
