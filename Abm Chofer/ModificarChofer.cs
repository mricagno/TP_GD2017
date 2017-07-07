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

namespace UberFrba.Abm_Chofer
{
    public partial class ModificarChofer : Form
    {

        public ObservableCollection<String> funcionalidades = new ObservableCollection<String>();
        public ModificarChofer()
        {
            InitializeComponent();
            funcionalidades = Repositorio.funcionalidadesUsuario(Sesion.rol);

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.chofer()).Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow chofer = Utils.getSelectedRow(GridChofer);
            if (chofer == null)
            {
                MessageBox.Show("Debe seleccionar un chofer", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = chofer.Cells[2].Value.ToString();


            try
            {
                String estabaDeshabilitado = Repositorio.deshabilitarChofer(dni);
                if (estabaDeshabilitado == "1")
                {
                    MessageBox.Show("El chofer ya se encontraba deshabilitado", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("El chofer se deshabilito correctamente", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.chofer()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow chofer = Utils.getSelectedRow(GridChofer);
            if (chofer == null)
            {
                MessageBox.Show("Debe seleccionar un chofer", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = chofer.Cells[2].Value.ToString();


            try
            {
                String estabaHabilitado = Repositorio.habilitarChofer(dni);
                if (estabaHabilitado == "1")
                {
                    MessageBox.Show("El chofer ya se encontraba habilitado", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("El chofer se habilito correctamente", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Principal(Tabs.chofer()).Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ModificarChofer_Load(object sender, EventArgs e)
        {
            ObservableCollection<UberFrba.Backend.DtoModificarChofer> choferes = Repositorio.todosLosChoferes();


            GridChofer.DataSource = choferes;
            GridChofer.Update();
            GridChofer.Refresh();

            if (funcionalidades.Contains("ALTA_CHOFER"))
                this.btnHabilitar.Enabled = true;
            if (funcionalidades.Contains("BAJA_CHOFER"))
                this.btnEliminar.Enabled = true;

            if (Sesion.rol == "ADMINISTRADOR")
            {
                this.btnEliminar.Enabled = true;
                btnHabilitar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow chofer = Utils.getSelectedRow(GridChofer);
            if (chofer == null)
            {
                MessageBox.Show("Debe seleccionar un chofer", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = chofer.Cells[2].Value.ToString();
            new EditarChofer(dni).Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           

            try
            {
                ObservableCollection<DtoModificarChofer> chofer_filtrado = Repositorio.filtrar_Chofer(nombre_Box.Text, apellido_Box.Text, documento_Box.Text);
                GridChofer.DataSource = chofer_filtrado;
                GridChofer.Update();
                GridChofer.Refresh();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnEditarRolesChofer_Click(object sender, EventArgs e)
        {
            DataGridViewRow chofer = Utils.getSelectedRow(GridChofer);
            if (chofer == null)
            {
                MessageBox.Show("Debe seleccionar un chofer", "Modificar Chofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String dni = chofer.Cells[2].Value.ToString();
            new EditarRolChofer(dni).Show();
            this.Close();
        }
    }
}
