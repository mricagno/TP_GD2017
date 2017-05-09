namespace UberFrba.Registro_Viajes
{
    partial class RegistroViajesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GridTodosLosViajes = new System.Windows.Forms.DataGridView();
            this.txtAutomovil = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.btnEliminarAuto = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            this.viajeGroupBox = new System.Windows.Forms.GroupBox();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtCantidadKm = new System.Windows.Forms.TextBox();
            this.txtFechaInicioViaje = new System.Windows.Forms.TextBox();
            this.txtFechaFinViaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).BeginInit();
            this.viajeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 39);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridTodosLosViajes
            // 
            this.GridTodosLosViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTodosLosViajes.Location = new System.Drawing.Point(34, 38);
            this.GridTodosLosViajes.Name = "GridTodosLosViajes";
            this.GridTodosLosViajes.RowTemplate.ReadOnly = true;
            this.GridTodosLosViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTodosLosViajes.Size = new System.Drawing.Size(482, 169);
            this.GridTodosLosViajes.TabIndex = 2;
            // 
            // txtAutomovil
            // 
            this.txtAutomovil.Location = new System.Drawing.Point(156, 19);
            this.txtAutomovil.Name = "txtAutomovil";
            this.txtAutomovil.Size = new System.Drawing.Size(201, 20);
            this.txtAutomovil.TabIndex = 3;
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(156, 99);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(196, 20);
            this.txtChofer.TabIndex = 4;
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(532, 95);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(83, 38);
            this.btnRegistrarViaje.TabIndex = 5;
            this.btnRegistrarViaje.Text = "Registrar Viaje";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // btnEliminarAuto
            // 
            this.btnEliminarAuto.Location = new System.Drawing.Point(532, 186);
            this.btnEliminarAuto.Name = "btnEliminarAuto";
            this.btnEliminarAuto.Size = new System.Drawing.Size(83, 38);
            this.btnEliminarAuto.TabIndex = 6;
            this.btnEliminarAuto.Text = "Eliminar";
            this.btnEliminarAuto.UseVisualStyleBackColor = true;
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(532, 139);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(83, 41);
            this.btnModificarAuto.TabIndex = 7;
            this.btnModificarAuto.Text = "modificarAuto";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
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
            this.viajeGroupBox.Location = new System.Drawing.Point(44, 227);
            this.viajeGroupBox.Name = "viajeGroupBox";
            this.viajeGroupBox.Size = new System.Drawing.Size(419, 248);
            this.viajeGroupBox.TabIndex = 8;
            this.viajeGroupBox.TabStop = false;
            this.viajeGroupBox.Text = "Viaje";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // txtFechaFinViaje
            // 
            this.txtFechaFinViaje.Location = new System.Drawing.Point(158, 222);
            this.txtFechaFinViaje.Name = "txtFechaFinViaje";
            this.txtFechaFinViaje.Size = new System.Drawing.Size(188, 20);
            this.txtFechaFinViaje.TabIndex = 11;
            // 
            // RegistroViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 575);
            this.Controls.Add(this.viajeGroupBox);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnEliminarAuto);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.GridTodosLosViajes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Name = "RegistroViajesForm";
            this.Text = "Registrar Viaje";
            this.Load += new System.EventHandler(this.RegistroViajesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).EndInit();
            this.viajeGroupBox.ResumeLayout(false);
            this.viajeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView GridTodosLosViajes;
        private System.Windows.Forms.TextBox txtAutomovil;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.Button btnEliminarAuto;
        private System.Windows.Forms.Button btnModificarAuto;
        private System.Windows.Forms.GroupBox viajeGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.TextBox txtFechaFinViaje;
        private System.Windows.Forms.TextBox txtFechaInicioViaje;
        private System.Windows.Forms.TextBox txtCantidadKm;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label lblChofer;
    }
}