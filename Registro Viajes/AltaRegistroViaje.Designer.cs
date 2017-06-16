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
            this.txtAutomovil = new System.Windows.Forms.TextBox();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtCantidadKm = new System.Windows.Forms.TextBox();
            this.viajeGroupBox = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbChoferHabilitado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            
            
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.viajeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAutomovil
            // 
            this.txtAutomovil.Location = new System.Drawing.Point(161, 62);
            this.txtAutomovil.Name = "txtAutomovil";
            this.txtAutomovil.ReadOnly = true;
            this.txtAutomovil.Size = new System.Drawing.Size(190, 20);
            this.txtAutomovil.TabIndex = 3;
            this.txtAutomovil.TextChanged += new System.EventHandler(this.txtAutomovil_TextChanged);
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(31, 65);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(53, 13);
            this.lblAutomovil.TabIndex = 5;
            this.lblAutomovil.Text = "Automovil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turno";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(31, 31);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(38, 13);
            this.lblChofer.TabIndex = 7;
            this.lblChofer.Text = "Chofer";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(161, 96);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(190, 20);
            this.txtTurno.TabIndex = 8;
            // 
            // txtCantidadKm
            // 
            this.txtCantidadKm.Location = new System.Drawing.Point(159, 167);
            this.txtCantidadKm.Name = "txtCantidadKm";
            this.txtCantidadKm.Size = new System.Drawing.Size(192, 20);
            this.txtCantidadKm.TabIndex = 9;
            // 
            // viajeGroupBox
            // 
            this.viajeGroupBox.Controls.Add(this.dateFechaFin);
            this.viajeGroupBox.Controls.Add(this.dateFechaInicio);
            this.viajeGroupBox.Controls.Add(this.label5);
            this.viajeGroupBox.Controls.Add(this.label4);
            this.viajeGroupBox.Controls.Add(this.label3);
            this.viajeGroupBox.Controls.Add(this.cmbChoferHabilitado);
            this.viajeGroupBox.Controls.Add(this.cmbCliente);
            this.viajeGroupBox.Controls.Add(this.label2);
            this.viajeGroupBox.Controls.Add(this.txtCantidadKm);
            this.viajeGroupBox.Controls.Add(this.lblChofer);
            this.viajeGroupBox.Controls.Add(this.txtTurno);
            this.viajeGroupBox.Controls.Add(this.label1);
            this.viajeGroupBox.Controls.Add(this.lblAutomovil);
            this.viajeGroupBox.Controls.Add(this.txtAutomovil);
            this.viajeGroupBox.Location = new System.Drawing.Point(58, 41);
            this.viajeGroupBox.Name = "viajeGroupBox";
            this.viajeGroupBox.Size = new System.Drawing.Size(419, 328);
            this.viajeGroupBox.TabIndex = 9;
            this.viajeGroupBox.TabStop = false;
            this.viajeGroupBox.Text = "Viaje";
            this.viajeGroupBox.Enter += new System.EventHandler(this.viajeGroupBox_Enter);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(58, 402);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(180, 403);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(114, 27);
            this.Guardar.TabIndex = 11;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(161, 132);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(190, 21);
            this.cmbCliente.TabIndex = 13;
            // 
            // cmbChoferHabilitado
            // 
            this.cmbChoferHabilitado.FormattingEnabled = true;
            this.cmbChoferHabilitado.Location = new System.Drawing.Point(159, 28);
            this.cmbChoferHabilitado.Name = "cmbChoferHabilitado";
            this.cmbChoferHabilitado.Size = new System.Drawing.Size(193, 21);
            this.cmbChoferHabilitado.TabIndex = 12;
            this.cmbChoferHabilitado.SelectedIndexChanged += new System.EventHandler(this.cmbChoferHabilitado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad Km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha Fin";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(159, 216);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dateFechaInicio.TabIndex = 16;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Location = new System.Drawing.Point(159, 253);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dateFechaFin.TabIndex = 17;
            // 
            // AltaRegistroViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 550);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.viajeGroupBox);
            this.Name = "AltaRegistroViaje";
            this.Text = "AltaRegistroViaje";
            this.Load += new System.EventHandler(this.AltaRegistroViaje_Load);
            this.viajeGroupBox.ResumeLayout(false);
            this.viajeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAutomovil;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtCantidadKm;
        private System.Windows.Forms.GroupBox viajeGroupBox;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChoferHabilitado;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}