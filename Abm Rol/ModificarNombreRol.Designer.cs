namespace UberFrba.Abm_Rol
{
    partial class ModificarNombreRol
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
            this.txtNuevoNombreRol = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNombreRolAModificarNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificarNombreRol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNuevoNombreRol);
            this.groupBox1.Location = new System.Drawing.Point(39, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Nombre";
            // 
            // txtNuevoNombreRol
            // 
            this.txtNuevoNombreRol.Location = new System.Drawing.Point(18, 27);
            this.txtNuevoNombreRol.Name = "txtNuevoNombreRol";
            this.txtNuevoNombreRol.Size = new System.Drawing.Size(154, 20);
            this.txtNuevoNombreRol.TabIndex = 0;
            this.txtNuevoNombreRol.TextChanged += new System.EventHandler(this.txtNuevoNombreRol_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNombreRolAModificarNombre);
            this.groupBox2.Location = new System.Drawing.Point(35, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rol a modificar";
            // 
            // lblNombreRolAModificarNombre
            // 
            this.lblNombreRolAModificarNombre.AutoSize = true;
            this.lblNombreRolAModificarNombre.Location = new System.Drawing.Point(23, 27);
            this.lblNombreRolAModificarNombre.Name = "lblNombreRolAModificarNombre";
            this.lblNombreRolAModificarNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombreRolAModificarNombre.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(43, 197);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 27);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificarNombreRol
            // 
            this.btnModificarNombreRol.Location = new System.Drawing.Point(147, 196);
            this.btnModificarNombreRol.Name = "btnModificarNombreRol";
            this.btnModificarNombreRol.Size = new System.Drawing.Size(82, 27);
            this.btnModificarNombreRol.TabIndex = 3;
            this.btnModificarNombreRol.Text = "Guardar";
            this.btnModificarNombreRol.UseVisualStyleBackColor = true;
            this.btnModificarNombreRol.Click += new System.EventHandler(this.btnModificarNombreRol_Click);
            // 
            // ModificarNombreRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnModificarNombreRol);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarNombreRol";
            this.Text = "Modificar Nombre Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNuevoNombreRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombreRolAModificarNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificarNombreRol;
    }
}