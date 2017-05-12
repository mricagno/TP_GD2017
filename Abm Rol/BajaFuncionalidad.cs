﻿using System;
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
    public partial class BajaFuncionalidad : Form
    {
        public BajaFuncionalidad()
        {
            InitializeComponent();
        }

        private void btnEliminarFuncionalidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La eliminacion de la funcionalidad se realizo correctamente", "Baja Funcionalidad", MessageBoxButtons.OK);
            new Principal().Show();
            this.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Close();
        }
    }
}
