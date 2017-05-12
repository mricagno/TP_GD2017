namespace UberFrba.Turno
{
    partial class AltaTurno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTurno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkHabilitadoTurno = new System.Windows.Forms.CheckBox();
            this.dateHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dateHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorKm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreTurno
            // 
            this.txtNombreTurno.Location = new System.Drawing.Point(120, 19);
            this.txtNombreTurno.Name = "txtNombreTurno";
            this.txtNombreTurno.Size = new System.Drawing.Size(145, 20);
            this.txtNombreTurno.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkHabilitadoTurno);
            this.groupBox1.Controls.Add(this.dateHoraFin);
            this.groupBox1.Controls.Add(this.dateHoraInicio);
            this.groupBox1.Controls.Add(this.txtPrecioBase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorKm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreTurno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // checkHabilitadoTurno
            // 
            this.checkHabilitadoTurno.AutoSize = true;
            this.checkHabilitadoTurno.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkHabilitadoTurno.Location = new System.Drawing.Point(35, 155);
            this.checkHabilitadoTurno.Name = "checkHabilitadoTurno";
            this.checkHabilitadoTurno.Size = new System.Drawing.Size(103, 17);
            this.checkHabilitadoTurno.TabIndex = 9;
            this.checkHabilitadoTurno.Text = "Habilitado          ";
            this.checkHabilitadoTurno.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkHabilitadoTurno.UseVisualStyleBackColor = true;
            // 
            // dateHoraFin
            // 
            this.dateHoraFin.CustomFormat = "hh:mm:ss";
            this.dateHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateHoraFin.Location = new System.Drawing.Point(120, 75);
            this.dateHoraFin.Name = "dateHoraFin";
            this.dateHoraFin.ShowUpDown = true;
            this.dateHoraFin.Size = new System.Drawing.Size(145, 20);
            this.dateHoraFin.TabIndex = 8;
            // 
            // dateHoraInicio
            // 
            this.dateHoraInicio.CustomFormat = "hh:mm:ss";
            this.dateHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateHoraInicio.Location = new System.Drawing.Point(120, 51);
            this.dateHoraInicio.Name = "dateHoraInicio";
            this.dateHoraInicio.ShowUpDown = true;
            this.dateHoraInicio.Size = new System.Drawing.Size(145, 20);
            this.dateHoraInicio.TabIndex = 3;
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(120, 129);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(145, 20);
            this.txtPrecioBase.TabIndex = 7;
            this.txtPrecioBase.TextChanged += new System.EventHandler(this.txtPrecioBase_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio Base";
            // 
            // txtValorKm
            // 
            this.txtValorKm.Location = new System.Drawing.Point(120, 100);
            this.txtValorKm.Name = "txtValorKm";
            this.txtValorKm.Size = new System.Drawing.Size(145, 20);
            this.txtValorKm.TabIndex = 5;
            this.txtValorKm.TextChanged += new System.EventHandler(this.txtValorKm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora Inicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(63, 239);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 27);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 298);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaTurno";
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.AltaTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTurno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateHoraFin;
        private System.Windows.Forms.DateTimePicker dateHoraInicio;
        private System.Windows.Forms.CheckBox checkHabilitadoTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;

    }
}