namespace UberFrba.Abm_Rol
{
    partial class AltaRol
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
            this.btnGuardarRolYAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarRolYAgregarFuncionalidad
            // 
            this.btnGuardarRolYAgregarFuncionalidad.Location = new System.Drawing.Point(159, 134);
            this.btnGuardarRolYAgregarFuncionalidad.Name = "btnGuardarRolYAgregarFuncionalidad";
            this.btnGuardarRolYAgregarFuncionalidad.Size = new System.Drawing.Size(114, 35);
            this.btnGuardarRolYAgregarFuncionalidad.TabIndex = 5;
            this.btnGuardarRolYAgregarFuncionalidad.Text = "Agregar Funcionalidades";
            this.btnGuardarRolYAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnGuardarRolYAgregarFuncionalidad.Click += new System.EventHandler(this.btnGuardarRolYAgregarFuncionalidad_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(47, 134);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(94, 35);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Location = new System.Drawing.Point(47, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 1 - Ingrese el nombre del Rol";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 221);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Funcionalidades";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(25, 36);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(177, 20);
            this.txtNombreRol.TabIndex = 1;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 207);
            this.Controls.Add(this.btnGuardarRolYAgregarFuncionalidad);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaRol";
            this.Text = "Alta Rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarRolYAgregarFuncionalidad;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}