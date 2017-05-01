namespace UberFrba
{
    partial class Administrador
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
            this.irAutosAbm = new System.Windows.Forms.Button();
            this.IrTurnosAbm = new System.Windows.Forms.Button();
            this.irRegistrarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // irAutosAbm
            // 
            this.irAutosAbm.Location = new System.Drawing.Point(27, 75);
            this.irAutosAbm.Name = "irAutosAbm";
            this.irAutosAbm.Size = new System.Drawing.Size(112, 36);
            this.irAutosAbm.TabIndex = 0;
            this.irAutosAbm.Text = "Ir a Autos";
            this.irAutosAbm.UseVisualStyleBackColor = true;
            this.irAutosAbm.Click += new System.EventHandler(this.button1_Click);
            // 
            // IrTurnosAbm
            // 
            this.IrTurnosAbm.Location = new System.Drawing.Point(27, 117);
            this.IrTurnosAbm.Name = "IrTurnosAbm";
            this.IrTurnosAbm.Size = new System.Drawing.Size(112, 34);
            this.IrTurnosAbm.TabIndex = 1;
            this.IrTurnosAbm.Text = "Ir a Turnos";
            this.IrTurnosAbm.UseVisualStyleBackColor = true;
            // 
            // irRegistrarViaje
            // 
            this.irRegistrarViaje.Location = new System.Drawing.Point(27, 157);
            this.irRegistrarViaje.Name = "irRegistrarViaje";
            this.irRegistrarViaje.Size = new System.Drawing.Size(109, 31);
            this.irRegistrarViaje.TabIndex = 2;
            this.irRegistrarViaje.Text = "Registrar Viaje";
            this.irRegistrarViaje.UseVisualStyleBackColor = true;
            this.irRegistrarViaje.Click += new System.EventHandler(this.irRegistrarViaje_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 294);
            this.Controls.Add(this.irRegistrarViaje);
            this.Controls.Add(this.IrTurnosAbm);
            this.Controls.Add(this.irAutosAbm);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button irAutosAbm;
        private System.Windows.Forms.Button IrTurnosAbm;
        private System.Windows.Forms.Button irRegistrarViaje;
    }
}