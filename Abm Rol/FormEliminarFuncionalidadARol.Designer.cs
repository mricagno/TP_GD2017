namespace UberFrba.Abm_Rol
{
    partial class FormEliminarFuncionalidadARol
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEliminarFuncionalidadDeRol = new System.Windows.Forms.Button();
            this.btnVolverAModificarRol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Funcionalidad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnEliminarFuncionalidadDeRol
            // 
            this.btnEliminarFuncionalidadDeRol.Location = new System.Drawing.Point(134, 147);
            this.btnEliminarFuncionalidadDeRol.Name = "btnEliminarFuncionalidadDeRol";
            this.btnEliminarFuncionalidadDeRol.Size = new System.Drawing.Size(97, 32);
            this.btnEliminarFuncionalidadDeRol.TabIndex = 1;
            this.btnEliminarFuncionalidadDeRol.Text = "Eliminar";
            this.btnEliminarFuncionalidadDeRol.UseVisualStyleBackColor = true;
            this.btnEliminarFuncionalidadDeRol.Click += new System.EventHandler(this.btnEliminarFuncionalidadDeRol_Click);
            // 
            // btnVolverAModificarRol
            // 
            this.btnVolverAModificarRol.Location = new System.Drawing.Point(32, 147);
            this.btnVolverAModificarRol.Name = "btnVolverAModificarRol";
            this.btnVolverAModificarRol.Size = new System.Drawing.Size(96, 32);
            this.btnVolverAModificarRol.TabIndex = 2;
            this.btnVolverAModificarRol.Text = "Volver";
            this.btnVolverAModificarRol.UseVisualStyleBackColor = true;
            this.btnVolverAModificarRol.Click += new System.EventHandler(this.btnVolverAModificarRol_Click);
            // 
            // FormEliminarFuncionalidadARol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVolverAModificarRol);
            this.Controls.Add(this.btnEliminarFuncionalidadDeRol);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEliminarFuncionalidadARol";
            this.Text = "Eliminar Funcionalidad";
            this.Load += new System.EventHandler(this.FormEliminarFuncionalidadARol_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEliminarFuncionalidadDeRol;
        private System.Windows.Forms.Button btnVolverAModificarRol;
    }
}