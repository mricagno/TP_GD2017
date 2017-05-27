namespace UberFrba.Abm_Rol
{
    partial class BajaRol
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
            this.btnBajaRol = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Location = new System.Drawing.Point(40, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el rol";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(15, 27);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(173, 21);
            this.cmbRoles.TabIndex = 0;
            // 
            // btnBajaRol
            // 
            this.btnBajaRol.Location = new System.Drawing.Point(177, 143);
            this.btnBajaRol.Name = "btnBajaRol";
            this.btnBajaRol.Size = new System.Drawing.Size(69, 28);
            this.btnBajaRol.TabIndex = 1;
            this.btnBajaRol.Text = "Eliminar";
            this.btnBajaRol.UseVisualStyleBackColor = true;
            this.btnBajaRol.Click += new System.EventHandler(this.btnBajaRol_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(51, 142);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(93, 28);
            this.btnMenuPrincipal.TabIndex = 2;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnBajaRol);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaRol";
            this.Text = "Baja Rol";
            this.Load += new System.EventHandler(this.BajaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnBajaRol;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}