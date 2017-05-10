namespace UberFrba.Registro_Viajes
{
    partial class AltaRegistroViaje
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
            this.txtFechaFinViaje = new System.Windows.Forms.TextBox();
            this.txtAutomovil = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtCantidadKm = new System.Windows.Forms.TextBox();
            this.txtFechaInicioViaje = new System.Windows.Forms.TextBox();
            this.viajeGroupBox = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.viajeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFechaFinViaje
            // 
            this.txtFechaFinViaje.Location = new System.Drawing.Point(161, 222);
            this.txtFechaFinViaje.Name = "txtFechaFinViaje";
            this.txtFechaFinViaje.Size = new System.Drawing.Size(188, 20);
            this.txtFechaFinViaje.TabIndex = 11;
            // 
            // txtAutomovil
            // 
            this.txtAutomovil.Location = new System.Drawing.Point(156, 19);
            this.txtAutomovil.Name = "txtAutomovil";
            this.txtAutomovil.Size = new System.Drawing.Size(201, 20);
            this.txtAutomovil.TabIndex = 3;
            this.txtAutomovil.TextChanged += new System.EventHandler(this.txtAutomovil_TextChanged);
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(156, 99);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(196, 20);
            this.txtChofer.TabIndex = 4;
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(26, 22);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(53, 13);
            this.lblAutomovil.TabIndex = 5;
            this.lblAutomovil.Text = "Automovil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turno";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(31, 102);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(38, 13);
            this.lblChofer.TabIndex = 7;
            this.lblChofer.Text = "Chofer";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(161, 62);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(190, 20);
            this.txtTurno.TabIndex = 8;
            // 
            // txtCantidadKm
            // 
            this.txtCantidadKm.Location = new System.Drawing.Point(159, 141);
            this.txtCantidadKm.Name = "txtCantidadKm";
            this.txtCantidadKm.Size = new System.Drawing.Size(192, 20);
            this.txtCantidadKm.TabIndex = 9;
            // 
            // txtFechaInicioViaje
            // 
            this.txtFechaInicioViaje.Location = new System.Drawing.Point(158, 182);
            this.txtFechaInicioViaje.Name = "txtFechaInicioViaje";
            this.txtFechaInicioViaje.Size = new System.Drawing.Size(193, 20);
            this.txtFechaInicioViaje.TabIndex = 10;
            // 
            // viajeGroupBox
            // 
            this.viajeGroupBox.Controls.Add(this.txtFechaFinViaje);
            this.viajeGroupBox.Controls.Add(this.txtFechaInicioViaje);
            this.viajeGroupBox.Controls.Add(this.txtCantidadKm);
            this.viajeGroupBox.Controls.Add(this.txtTurno);
            this.viajeGroupBox.Controls.Add(this.lblChofer);
            this.viajeGroupBox.Controls.Add(this.label1);
            this.viajeGroupBox.Controls.Add(this.lblAutomovil);
            this.viajeGroupBox.Controls.Add(this.txtChofer);
            this.viajeGroupBox.Controls.Add(this.txtAutomovil);
            this.viajeGroupBox.Location = new System.Drawing.Point(58, 41);
            this.viajeGroupBox.Name = "viajeGroupBox";
            this.viajeGroupBox.Size = new System.Drawing.Size(419, 251);
            this.viajeGroupBox.TabIndex = 9;
            this.viajeGroupBox.TabStop = false;
            this.viajeGroupBox.Text = "Viaje";
            this.viajeGroupBox.Enter += new System.EventHandler(this.viajeGroupBox_Enter);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(57, 309);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(179, 312);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(114, 24);
            this.Guardar.TabIndex = 11;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // AltaRegistroViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 353);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.viajeGroupBox);
            this.Name = "AltaRegistroViaje";
            this.Text = "AltaRegistroViaje";
            this.viajeGroupBox.ResumeLayout(false);
            this.viajeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaFinViaje;
        private System.Windows.Forms.TextBox txtAutomovil;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtCantidadKm;
        private System.Windows.Forms.TextBox txtFechaInicioViaje;
        private System.Windows.Forms.GroupBox viajeGroupBox;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button Guardar;
    }
}