﻿namespace UberFrba.Abm_Chofer
{
    partial class ModificarChofer
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
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.documento_Box = new System.Windows.Forms.TextBox();
            this.apellido_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_Box = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.GridChofer = new System.Windows.Forms.DataGridView();
            this.btnEditarRolesChofer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(233, 324);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(99, 33);
            this.btnHabilitar.TabIndex = 10;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(22, 324);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(94, 34);
            this.btnMenuPrincipal.TabIndex = 9;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(338, 323);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 34);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(135, 324);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Deshabilitar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.documento_Box);
            this.groupBox1.Controls.Add(this.apellido_Box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre_Box);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.GridChofer);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 291);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(221, 59);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // documento_Box
            // 
            this.documento_Box.Location = new System.Drawing.Point(90, 61);
            this.documento_Box.Name = "documento_Box";
            this.documento_Box.Size = new System.Drawing.Size(100, 20);
            this.documento_Box.TabIndex = 5;
            // 
            // apellido_Box
            // 
            this.apellido_Box.Location = new System.Drawing.Point(289, 28);
            this.apellido_Box.Name = "apellido_Box";
            this.apellido_Box.Size = new System.Drawing.Size(100, 20);
            this.apellido_Box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // nombre_Box
            // 
            this.nombre_Box.Location = new System.Drawing.Point(90, 25);
            this.nombre_Box.Name = "nombre_Box";
            this.nombre_Box.Size = new System.Drawing.Size(100, 20);
            this.nombre_Box.TabIndex = 1;
            this.nombre_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(18, 25);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // GridChofer
            // 
            this.GridChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridChofer.Location = new System.Drawing.Point(21, 117);
            this.GridChofer.MultiSelect = false;
            this.GridChofer.Name = "GridChofer";
            this.GridChofer.ReadOnly = true;
            this.GridChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridChofer.Size = new System.Drawing.Size(475, 150);
            this.GridChofer.TabIndex = 0;
            // 
            // btnEditarRolesChofer
            // 
            this.btnEditarRolesChofer.Location = new System.Drawing.Point(437, 323);
            this.btnEditarRolesChofer.Name = "btnEditarRolesChofer";
            this.btnEditarRolesChofer.Size = new System.Drawing.Size(81, 34);
            this.btnEditarRolesChofer.TabIndex = 11;
            this.btnEditarRolesChofer.Text = "Editar Roles";
            this.btnEditarRolesChofer.UseVisualStyleBackColor = true;
            this.btnEditarRolesChofer.Click += new System.EventHandler(this.btnEditarRolesChofer_Click);
            // 
            // ModificarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 370);
            this.Controls.Add(this.btnEditarRolesChofer);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarChofer";
            this.Text = "Modificar Chofer";
            this.Load += new System.EventHandler(this.ModificarChofer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridChofer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox documento_Box;
        private System.Windows.Forms.TextBox apellido_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_Box;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView GridChofer;
        private System.Windows.Forms.Button btnEditarRolesChofer;
    }
}