﻿namespace UberFrba.Abm_Rol
{
    partial class ModificarRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificarNombreRol = new System.Windows.Forms.Button();
            this.btnAgregarFuncionalidadARol = new System.Windows.Forms.Button();
            this.btnHabilitarRol = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Location = new System.Drawing.Point(80, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Rol";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(23, 32);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(212, 21);
            this.cmbRoles.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeshabilitar);
            this.groupBox2.Controls.Add(this.btnModificarNombreRol);
            this.groupBox2.Controls.Add(this.btnAgregarFuncionalidadARol);
            this.groupBox2.Controls.Add(this.btnHabilitarRol);
            this.groupBox2.Location = new System.Drawing.Point(84, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Acción";
            // 
            // btnModificarNombreRol
            // 
            this.btnModificarNombreRol.Location = new System.Drawing.Point(19, 84);
            this.btnModificarNombreRol.Name = "btnModificarNombreRol";
            this.btnModificarNombreRol.Size = new System.Drawing.Size(134, 39);
            this.btnModificarNombreRol.TabIndex = 2;
            this.btnModificarNombreRol.Text = "Modificar Nombre";
            this.btnModificarNombreRol.UseVisualStyleBackColor = true;
            this.btnModificarNombreRol.Click += new System.EventHandler(this.btnModificarNombreRol_Click);
            // 
            // btnAgregarFuncionalidadARol
            // 
            this.btnAgregarFuncionalidadARol.Location = new System.Drawing.Point(159, 32);
            this.btnAgregarFuncionalidadARol.Name = "btnAgregarFuncionalidadARol";
            this.btnAgregarFuncionalidadARol.Size = new System.Drawing.Size(134, 38);
            this.btnAgregarFuncionalidadARol.TabIndex = 1;
            this.btnAgregarFuncionalidadARol.Text = "Modificar Funcionalidades";
            this.btnAgregarFuncionalidadARol.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidadARol.Click += new System.EventHandler(this.btnAgregarFuncionalidadARol_Click);
            // 
            // btnHabilitarRol
            // 
            this.btnHabilitarRol.Location = new System.Drawing.Point(19, 32);
            this.btnHabilitarRol.Name = "btnHabilitarRol";
            this.btnHabilitarRol.Size = new System.Drawing.Size(134, 38);
            this.btnHabilitarRol.TabIndex = 0;
            this.btnHabilitarRol.Text = "Habilitar";
            this.btnHabilitarRol.UseVisualStyleBackColor = true;
            this.btnHabilitarRol.Click += new System.EventHandler(this.btnHabilitarRol_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(160, 84);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(133, 39);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar ///no mostar. es baja";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Visible = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHabilitarRol;
        private System.Windows.Forms.Button btnModificarNombreRol;
        private System.Windows.Forms.Button btnAgregarFuncionalidadARol;
        private System.Windows.Forms.Button btnDeshabilitar;
    }
}