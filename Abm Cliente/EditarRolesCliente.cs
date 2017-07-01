﻿using System;
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
    public partial class EditarRolesCliente : Form
    {
        public String dni;
        public EditarRolesCliente(String unDni)
        {
            InitializeComponent();
            dni = unDni;
        }

        private void btnGuardarRolesChofer_Click(object sender, EventArgs e)
        {
            if (lstRoles.Items.Count <= 0)
            {
                MessageBox.Show("Debe seleccionarse al menos un rol", "Edición roles Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                Repositorio.eliminarRolesExtraDeCliente(dni);
                foreach (var rol in lstAgregarRoles.Items)
                {

                    Repositorio.agregarRolACliente(dni, rol);
                }

                MessageBox.Show("Se editaron los roles correctamente", "Uber", MessageBoxButtons.OK);
                new ModificarCliente().Show();
                this.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Uber", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            new ModificarCliente().Show();
            this.Close();
        }

        private void EditarRolesCliente_Load(object sender, EventArgs e)
        {
            lstRoles.Items.Clear();
            lstAgregarRoles.Items.Clear();

            

            foreach (string s in Repositorio.todosLosRolesExtra())
            {
                lstRoles.Items.Add(s);
            }

            foreach (string s in Repositorio.todosLosRolesExtraDeCliente(dni))
            {
                lstAgregarRoles.Items.Add(s);
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            if (lstRoles.SelectedItem == null)
                return;

            if (lstAgregarRoles.Items.Contains(lstRoles.SelectedItem.ToString()))
                return;
            lstAgregarRoles.Items.Add(lstRoles.SelectedItem.ToString());
        }

        private void btnSacarRol_Click(object sender, EventArgs e)
        {
            if (lstAgregarRoles.SelectedItem == null)
                return;


            lstAgregarRoles.Items.Remove(lstAgregarRoles.SelectedItem.ToString());
        }
    }
}
