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
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarRolYAgregarFuncionalidad
            // 
            this.btnGuardarRolYAgregarFuncionalidad.Location = new System.Drawing.Point(145, 186);
            this.btnGuardarRolYAgregarFuncionalidad.Name = "btnGuardarRolYAgregarFuncionalidad";
            this.btnGuardarRolYAgregarFuncionalidad.Size = new System.Drawing.Size(137, 26);
            this.btnGuardarRolYAgregarFuncionalidad.TabIndex = 5;
            this.btnGuardarRolYAgregarFuncionalidad.Text = "Agregar Funcionalidades";
            this.btnGuardarRolYAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnGuardarRolYAgregarFuncionalidad.Click += new System.EventHandler(this.btnGuardarRolYAgregarFuncionalidad_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(12, 186);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(117, 26);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Location = new System.Drawing.Point(50, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 1 - Ingrese el nombre del Rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(25, 36);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(145, 20);
            this.txtNombreRol.TabIndex = 1;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.btnGuardarRolYAgregarFuncionalidad);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaRol";
            this.Text = "Alta Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarRolYAgregarFuncionalidad;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreRol;

    }
}