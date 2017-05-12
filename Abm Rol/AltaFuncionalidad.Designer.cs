namespace UberFrba.Abm_Rol
{
    partial class AltaFuncionalidad
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
            this.txtNombreFuncionalidad = new System.Windows.Forms.TextBox();
            this.btnAltaFuncionalidad = new System.Windows.Forms.Button();
            this.btnVolverAMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreFuncionalidad);
            this.groupBox1.Location = new System.Drawing.Point(44, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Funcionalidad";
            // 
            // txtNombreFuncionalidad
            // 
            this.txtNombreFuncionalidad.Location = new System.Drawing.Point(21, 46);
            this.txtNombreFuncionalidad.Name = "txtNombreFuncionalidad";
            this.txtNombreFuncionalidad.Size = new System.Drawing.Size(139, 20);
            this.txtNombreFuncionalidad.TabIndex = 0;
            // 
            // btnAltaFuncionalidad
            // 
            this.btnAltaFuncionalidad.Location = new System.Drawing.Point(135, 176);
            this.btnAltaFuncionalidad.Name = "btnAltaFuncionalidad";
            this.btnAltaFuncionalidad.Size = new System.Drawing.Size(81, 29);
            this.btnAltaFuncionalidad.TabIndex = 1;
            this.btnAltaFuncionalidad.Text = "Guardar";
            this.btnAltaFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAltaFuncionalidad.Click += new System.EventHandler(this.btnAltaFuncionalidad_Click);
            // 
            // btnVolverAMenu
            // 
            this.btnVolverAMenu.Location = new System.Drawing.Point(37, 177);
            this.btnVolverAMenu.Name = "btnVolverAMenu";
            this.btnVolverAMenu.Size = new System.Drawing.Size(84, 27);
            this.btnVolverAMenu.TabIndex = 2;
            this.btnVolverAMenu.Text = "Volver";
            this.btnVolverAMenu.UseVisualStyleBackColor = true;
            this.btnVolverAMenu.Click += new System.EventHandler(this.btnVolverAMenu_Click);
            // 
            // AltaFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 262);
            this.Controls.Add(this.btnVolverAMenu);
            this.Controls.Add(this.btnAltaFuncionalidad);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaFuncionalidad";
            this.Text = "Alta funcionalidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreFuncionalidad;
        private System.Windows.Forms.Button btnAltaFuncionalidad;
        private System.Windows.Forms.Button btnVolverAMenu;

    }
}