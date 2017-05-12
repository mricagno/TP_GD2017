namespace UberFrba.Abm_Rol
{
    partial class AgregarFuncionalidadARol
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
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.cmbFuncionalides = new System.Windows.Forms.ComboBox();
            this.btnFinalizarAgregadoDeFuncionalidades = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarFuncionalidad);
            this.groupBox1.Controls.Add(this.cmbFuncionalides);
            this.groupBox1.Location = new System.Drawing.Point(45, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 2 - Agregar funcionalidades";
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(199, 44);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(32, 19);
            this.btnAgregarFuncionalidad.TabIndex = 1;
            this.btnAgregarFuncionalidad.Text = "+";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidad.Click += new System.EventHandler(this.btnAgregarFuncionalidad_Click);
            // 
            // cmbFuncionalides
            // 
            this.cmbFuncionalides.FormattingEnabled = true;
            this.cmbFuncionalides.Location = new System.Drawing.Point(25, 42);
            this.cmbFuncionalides.Name = "cmbFuncionalides";
            this.cmbFuncionalides.Size = new System.Drawing.Size(163, 21);
            this.cmbFuncionalides.TabIndex = 0;
            // 
            // btnFinalizarAgregadoDeFuncionalidades
            // 
            this.btnFinalizarAgregadoDeFuncionalidades.Location = new System.Drawing.Point(241, 179);
            this.btnFinalizarAgregadoDeFuncionalidades.Name = "btnFinalizarAgregadoDeFuncionalidades";
            this.btnFinalizarAgregadoDeFuncionalidades.Size = new System.Drawing.Size(73, 21);
            this.btnFinalizarAgregadoDeFuncionalidades.TabIndex = 1;
            this.btnFinalizarAgregadoDeFuncionalidades.Text = "Finalizar";
            this.btnFinalizarAgregadoDeFuncionalidades.UseVisualStyleBackColor = true;
            this.btnFinalizarAgregadoDeFuncionalidades.Click += new System.EventHandler(this.btnFinalizarAgregadoDeFuncionalidades_Click);
            // 
            // AgregarFuncionalidadARol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.btnFinalizarAgregadoDeFuncionalidades);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarFuncionalidadARol";
            this.Text = "AgregarRolAFuncionalidad";
            this.Load += new System.EventHandler(this.AgregarRolAFuncionalidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
        private System.Windows.Forms.ComboBox cmbFuncionalides;
        private System.Windows.Forms.Button btnFinalizarAgregadoDeFuncionalidades;
    }
}