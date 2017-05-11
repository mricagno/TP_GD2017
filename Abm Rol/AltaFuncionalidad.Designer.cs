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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFuncionalidad = new System.Windows.Forms.TextBox();
            this.btnGuardarFuncionalidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarFuncionalidad);
            this.groupBox1.Controls.Add(this.txtNombreFuncionalidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreFuncionalidad
            // 
            this.txtNombreFuncionalidad.Location = new System.Drawing.Point(72, 37);
            this.txtNombreFuncionalidad.Name = "txtNombreFuncionalidad";
            this.txtNombreFuncionalidad.Size = new System.Drawing.Size(125, 20);
            this.txtNombreFuncionalidad.TabIndex = 1;
            // 
            // btnGuardarFuncionalidad
            // 
            this.btnGuardarFuncionalidad.Location = new System.Drawing.Point(72, 72);
            this.btnGuardarFuncionalidad.Name = "btnGuardarFuncionalidad";
            this.btnGuardarFuncionalidad.Size = new System.Drawing.Size(113, 26);
            this.btnGuardarFuncionalidad.TabIndex = 2;
            this.btnGuardarFuncionalidad.Text = "Guardar";
            this.btnGuardarFuncionalidad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AltaFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaFuncionalidad";
            this.Text = "Alta funcionalidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarFuncionalidad;
        private System.Windows.Forms.TextBox txtNombreFuncionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}