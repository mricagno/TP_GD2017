namespace UberFrba.Abm_Rol
{
    partial class AgregarFuncARol
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
            this.btnSacarFuncionalidad = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.lstAgregarFuncionalidades = new System.Windows.Forms.ListBox();
            this.btnFinalizarAgregadoDeFuncionalidades = new System.Windows.Forms.Button();
            this.lstFuncionalidades = new System.Windows.Forms.ListBox();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacarFuncionalidad);
            this.groupBox1.Controls.Add(this.btnMenuPrincipal);
            this.groupBox1.Controls.Add(this.lstAgregarFuncionalidades);
            this.groupBox1.Controls.Add(this.btnFinalizarAgregadoDeFuncionalidades);
            this.groupBox1.Controls.Add(this.lstFuncionalidades);
            this.groupBox1.Controls.Add(this.btnAgregarFuncionalidad);
            this.groupBox1.Location = new System.Drawing.Point(70, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 2 - Agregar funcionalidades";
            // 
            // btnSacarFuncionalidad
            // 
            this.btnSacarFuncionalidad.Location = new System.Drawing.Point(348, 29);
            this.btnSacarFuncionalidad.Name = "btnSacarFuncionalidad";
            this.btnSacarFuncionalidad.Size = new System.Drawing.Size(32, 23);
            this.btnSacarFuncionalidad.TabIndex = 5;
            this.btnSacarFuncionalidad.Text = "-";
            this.btnSacarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnSacarFuncionalidad.Click += new System.EventHandler(this.btnSacarFuncionalidad_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(20, 218);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 31);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Text = "Salir sin asignar";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // lstAgregarFuncionalidades
            // 
            this.lstAgregarFuncionalidades.FormattingEnabled = true;
            this.lstAgregarFuncionalidades.Location = new System.Drawing.Point(206, 29);
            this.lstAgregarFuncionalidades.Name = "lstAgregarFuncionalidades";
            this.lstAgregarFuncionalidades.Size = new System.Drawing.Size(120, 160);
            this.lstAgregarFuncionalidades.TabIndex = 3;
            // 
            // btnFinalizarAgregadoDeFuncionalidades
            // 
            this.btnFinalizarAgregadoDeFuncionalidades.Location = new System.Drawing.Point(239, 218);
            this.btnFinalizarAgregadoDeFuncionalidades.Name = "btnFinalizarAgregadoDeFuncionalidades";
            this.btnFinalizarAgregadoDeFuncionalidades.Size = new System.Drawing.Size(87, 32);
            this.btnFinalizarAgregadoDeFuncionalidades.TabIndex = 1;
            this.btnFinalizarAgregadoDeFuncionalidades.Text = "Guardar";
            this.btnFinalizarAgregadoDeFuncionalidades.UseVisualStyleBackColor = true;
            this.btnFinalizarAgregadoDeFuncionalidades.Click += new System.EventHandler(this.btnFinalizarAgregadoDeFuncionalidades_Click_1);
            // 
            // lstFuncionalidades
            // 
            this.lstFuncionalidades.FormattingEnabled = true;
            this.lstFuncionalidades.Location = new System.Drawing.Point(16, 29);
            this.lstFuncionalidades.Name = "lstFuncionalidades";
            this.lstFuncionalidades.Size = new System.Drawing.Size(120, 160);
            this.lstFuncionalidades.TabIndex = 2;
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(153, 29);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(32, 25);
            this.btnAgregarFuncionalidad.TabIndex = 1;
            this.btnAgregarFuncionalidad.Text = "+";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidad.Click += new System.EventHandler(this.btnAgregarFuncionalidad_Click_1);
            // 
            // AgregarFuncARol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 425);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarFuncARol";
            this.Text = "AgregarFuncARol";
            this.Load += new System.EventHandler(this.AgregarFuncARol_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.ListBox lstAgregarFuncionalidades;
        private System.Windows.Forms.Button btnFinalizarAgregadoDeFuncionalidades;
        private System.Windows.Forms.ListBox lstFuncionalidades;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
        private System.Windows.Forms.Button btnSacarFuncionalidad;
    }
}