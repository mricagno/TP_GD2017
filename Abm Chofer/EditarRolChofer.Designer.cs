namespace UberFrba.Abm_Chofer
{
    partial class EditarRolChofer
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
            this.btnSacarRol = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.lstAgregarRoles = new System.Windows.Forms.ListBox();
            this.btnGuardarRolesChofer = new System.Windows.Forms.Button();
            this.lstRoles = new System.Windows.Forms.ListBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSacarRol);
            this.groupBox1.Controls.Add(this.btnMenuPrincipal);
            this.groupBox1.Controls.Add(this.lstAgregarRoles);
            this.groupBox1.Controls.Add(this.btnGuardarRolesChofer);
            this.groupBox1.Controls.Add(this.lstRoles);
            this.groupBox1.Controls.Add(this.btnAgregarRol);
            this.groupBox1.Location = new System.Drawing.Point(39, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de Roles";
            // 
            // btnSacarRol
            // 
            this.btnSacarRol.Location = new System.Drawing.Point(392, 29);
            this.btnSacarRol.Name = "btnSacarRol";
            this.btnSacarRol.Size = new System.Drawing.Size(32, 23);
            this.btnSacarRol.TabIndex = 5;
            this.btnSacarRol.Text = "-";
            this.btnSacarRol.UseVisualStyleBackColor = true;
            this.btnSacarRol.Click += new System.EventHandler(this.btnSacarRol_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(16, 243);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 31);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // lstAgregarRoles
            // 
            this.lstAgregarRoles.FormattingEnabled = true;
            this.lstAgregarRoles.Location = new System.Drawing.Point(231, 29);
            this.lstAgregarRoles.Name = "lstAgregarRoles";
            this.lstAgregarRoles.Size = new System.Drawing.Size(155, 160);
            this.lstAgregarRoles.TabIndex = 3;
            // 
            // btnGuardarRolesChofer
            // 
            this.btnGuardarRolesChofer.Location = new System.Drawing.Point(299, 242);
            this.btnGuardarRolesChofer.Name = "btnGuardarRolesChofer";
            this.btnGuardarRolesChofer.Size = new System.Drawing.Size(87, 32);
            this.btnGuardarRolesChofer.TabIndex = 1;
            this.btnGuardarRolesChofer.Text = "Guardar";
            this.btnGuardarRolesChofer.UseVisualStyleBackColor = true;
            this.btnGuardarRolesChofer.Click += new System.EventHandler(this.btnGuardarRolesChofer_Click);
            // 
            // lstRoles
            // 
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.Location = new System.Drawing.Point(16, 29);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(171, 160);
            this.lstRoles.TabIndex = 2;
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(193, 29);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(32, 25);
            this.btnAgregarRol.TabIndex = 1;
            this.btnAgregarRol.Text = "+";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atención:  El rol chofer no está disponible para edición";
            // 
            // EditarRolChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditarRolChofer";
            this.Text = "Editar Rol Chofer";
            this.Load += new System.EventHandler(this.EditarRolChofer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacarRol;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.ListBox lstAgregarRoles;
        private System.Windows.Forms.Button btnGuardarRolesChofer;
        private System.Windows.Forms.ListBox lstRoles;
        private System.Windows.Forms.Button btnAgregarRol;
    }
}