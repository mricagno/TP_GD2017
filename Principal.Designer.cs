namespace UberFrba
{
    partial class Principal
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
            this.btnNuevoTurno = new System.Windows.Forms.Button();
            this.irRegistrarViaje = new System.Windows.Forms.Button();
            this.btnAltaAuto = new System.Windows.Forms.Button();
            this.btnBajaAuto = new System.Windows.Forms.Button();
            this.btnAltaRol = new System.Windows.Forms.Button();
            this.btnModificarRol = new System.Windows.Forms.Button();
            this.btnBajaRol = new System.Windows.Forms.Button();
            this.tblMenu = new System.Windows.Forms.TabControl();
            this.tabSeguridad = new System.Windows.Forms.TabPage();
            this.tabChoferes = new System.Windows.Forms.TabPage();
            this.btnModificarChofer = new System.Windows.Forms.Button();
            this.btnNuevoChofer = new System.Windows.Forms.Button();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.ModificarCliente = new System.Windows.Forms.Button();
            this.NuevoCliente = new System.Windows.Forms.Button();
            this.tabTurnos = new System.Windows.Forms.TabPage();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.tabAutos = new System.Windows.Forms.TabPage();
            this.tabViajes = new System.Windows.Forms.TabPage();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.tabContabilidad = new System.Windows.Forms.TabPage();
            this.btnFacturacionClientes = new System.Windows.Forms.Button();
            this.btnRendicionViajes = new System.Windows.Forms.Button();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.btnConsultarEstadistica = new System.Windows.Forms.Button();
            this.radioButtonMismoAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonMasConsumo = new System.Windows.Forms.RadioButton();
            this.radioButtonViajeMasLargo = new System.Windows.Forms.RadioButton();
            this.radioButtonMasRecaudacion = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblMenu.SuspendLayout();
            this.tabSeguridad.SuspendLayout();
            this.tabChoferes.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabTurnos.SuspendLayout();
            this.tabAutos.SuspendLayout();
            this.tabViajes.SuspendLayout();
            this.tabContabilidad.SuspendLayout();
            this.tabEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoTurno
            // 
            this.btnNuevoTurno.Location = new System.Drawing.Point(23, 35);
            this.btnNuevoTurno.Name = "btnNuevoTurno";
            this.btnNuevoTurno.Size = new System.Drawing.Size(112, 34);
            this.btnNuevoTurno.TabIndex = 1;
            this.btnNuevoTurno.Text = "Nuevo Turno";
            this.btnNuevoTurno.UseVisualStyleBackColor = true;
            this.btnNuevoTurno.Click += new System.EventHandler(this.btnNuevoTurno_Click);
            // 
            // irRegistrarViaje
            // 
            this.irRegistrarViaje.Location = new System.Drawing.Point(19, 77);
            this.irRegistrarViaje.Name = "irRegistrarViaje";
            this.irRegistrarViaje.Size = new System.Drawing.Size(109, 31);
            this.irRegistrarViaje.TabIndex = 2;
            this.irRegistrarViaje.Text = "Registrar Viaje";
            this.irRegistrarViaje.UseVisualStyleBackColor = true;
            this.irRegistrarViaje.Click += new System.EventHandler(this.irRegistrarViaje_Click);
            // 
            // btnAltaAuto
            // 
            this.btnAltaAuto.Location = new System.Drawing.Point(40, 33);
            this.btnAltaAuto.Name = "btnAltaAuto";
            this.btnAltaAuto.Size = new System.Drawing.Size(108, 34);
            this.btnAltaAuto.TabIndex = 5;
            this.btnAltaAuto.Text = "Nuevo Auto";
            this.btnAltaAuto.UseVisualStyleBackColor = true;
            this.btnAltaAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnBajaAuto
            // 
            this.btnBajaAuto.Location = new System.Drawing.Point(40, 83);
            this.btnBajaAuto.Name = "btnBajaAuto";
            this.btnBajaAuto.Size = new System.Drawing.Size(108, 39);
            this.btnBajaAuto.TabIndex = 6;
            this.btnBajaAuto.Text = "Baja Auto";
            this.btnBajaAuto.UseVisualStyleBackColor = true;
            this.btnBajaAuto.Click += new System.EventHandler(this.btnBajaAuto_Click);
            // 
            // btnAltaRol
            // 
            this.btnAltaRol.Location = new System.Drawing.Point(32, 31);
            this.btnAltaRol.Name = "btnAltaRol";
            this.btnAltaRol.Size = new System.Drawing.Size(98, 27);
            this.btnAltaRol.TabIndex = 0;
            this.btnAltaRol.Text = "Alta Rol";
            this.btnAltaRol.UseVisualStyleBackColor = true;
            this.btnAltaRol.Click += new System.EventHandler(this.btnAltaRol_Click);
            // 
            // btnModificarRol
            // 
            this.btnModificarRol.Location = new System.Drawing.Point(32, 64);
            this.btnModificarRol.Name = "btnModificarRol";
            this.btnModificarRol.Size = new System.Drawing.Size(98, 30);
            this.btnModificarRol.TabIndex = 1;
            this.btnModificarRol.Text = "Modificar Rol";
            this.btnModificarRol.UseVisualStyleBackColor = true;
            this.btnModificarRol.Click += new System.EventHandler(this.btnModificarRol_Click);
            // 
            // btnBajaRol
            // 
            this.btnBajaRol.Location = new System.Drawing.Point(32, 100);
            this.btnBajaRol.Name = "btnBajaRol";
            this.btnBajaRol.Size = new System.Drawing.Size(98, 31);
            this.btnBajaRol.TabIndex = 2;
            this.btnBajaRol.Text = "Baja Rol";
            this.btnBajaRol.UseVisualStyleBackColor = true;
            this.btnBajaRol.Click += new System.EventHandler(this.btnBajaRol_Click);
            // 
            // tblMenu
            // 
            this.tblMenu.Controls.Add(this.tabSeguridad);
            this.tblMenu.Controls.Add(this.tabChoferes);
            this.tblMenu.Controls.Add(this.tabCliente);
            this.tblMenu.Controls.Add(this.tabTurnos);
            this.tblMenu.Controls.Add(this.tabAutos);
            this.tblMenu.Controls.Add(this.tabViajes);
            this.tblMenu.Controls.Add(this.tabContabilidad);
            this.tblMenu.Controls.Add(this.tabEstadisticas);
            this.tblMenu.Location = new System.Drawing.Point(51, 53);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.SelectedIndex = 0;
            this.tblMenu.Size = new System.Drawing.Size(451, 300);
            this.tblMenu.TabIndex = 6;
            // 
            // tabSeguridad
            // 
            this.tabSeguridad.Controls.Add(this.btnBajaRol);
            this.tabSeguridad.Controls.Add(this.btnModificarRol);
            this.tabSeguridad.Controls.Add(this.btnAltaRol);
            this.tabSeguridad.Location = new System.Drawing.Point(4, 22);
            this.tabSeguridad.Name = "tabSeguridad";
            this.tabSeguridad.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeguridad.Size = new System.Drawing.Size(443, 274);
            this.tabSeguridad.TabIndex = 0;
            this.tabSeguridad.Text = "Seguridad";
            this.tabSeguridad.UseVisualStyleBackColor = true;
            // 
            // tabChoferes
            // 
            this.tabChoferes.Controls.Add(this.btnModificarChofer);
            this.tabChoferes.Controls.Add(this.btnNuevoChofer);
            this.tabChoferes.Location = new System.Drawing.Point(4, 22);
            this.tabChoferes.Name = "tabChoferes";
            this.tabChoferes.Size = new System.Drawing.Size(443, 274);
            this.tabChoferes.TabIndex = 6;
            this.tabChoferes.Text = "Choferes";
            this.tabChoferes.UseVisualStyleBackColor = true;
            this.tabChoferes.Click += new System.EventHandler(this.tabChoferes_Click);
            // 
            // btnModificarChofer
            // 
            this.btnModificarChofer.Location = new System.Drawing.Point(33, 91);
            this.btnModificarChofer.Name = "btnModificarChofer";
            this.btnModificarChofer.Size = new System.Drawing.Size(100, 44);
            this.btnModificarChofer.TabIndex = 1;
            this.btnModificarChofer.Text = "Modificar Chofer";
            this.btnModificarChofer.UseVisualStyleBackColor = true;
            this.btnModificarChofer.Click += new System.EventHandler(this.btnModificarChofer_Click);
            // 
            // btnNuevoChofer
            // 
            this.btnNuevoChofer.Location = new System.Drawing.Point(33, 42);
            this.btnNuevoChofer.Name = "btnNuevoChofer";
            this.btnNuevoChofer.Size = new System.Drawing.Size(100, 43);
            this.btnNuevoChofer.TabIndex = 0;
            this.btnNuevoChofer.Text = "Nuevo Chofer";
            this.btnNuevoChofer.UseVisualStyleBackColor = true;
            this.btnNuevoChofer.Click += new System.EventHandler(this.btnNuevoChofer_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.ModificarCliente);
            this.tabCliente.Controls.Add(this.NuevoCliente);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Size = new System.Drawing.Size(443, 274);
            this.tabCliente.TabIndex = 5;
            this.tabCliente.Text = "Clientes";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.Location = new System.Drawing.Point(31, 88);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Size = new System.Drawing.Size(99, 37);
            this.ModificarCliente.TabIndex = 1;
            this.ModificarCliente.Text = "Modificar Cliente";
            this.ModificarCliente.UseVisualStyleBackColor = true;
            this.ModificarCliente.Click += new System.EventHandler(this.ModificarCliente_Click);
            // 
            // NuevoCliente
            // 
            this.NuevoCliente.Location = new System.Drawing.Point(29, 37);
            this.NuevoCliente.Name = "NuevoCliente";
            this.NuevoCliente.Size = new System.Drawing.Size(102, 37);
            this.NuevoCliente.TabIndex = 0;
            this.NuevoCliente.Text = "Nuevo Cliente";
            this.NuevoCliente.UseVisualStyleBackColor = true;
            this.NuevoCliente.Click += new System.EventHandler(this.NuevoCliente_Click);
            // 
            // tabTurnos
            // 
            this.tabTurnos.Controls.Add(this.btnEliminarTurno);
            this.tabTurnos.Controls.Add(this.btnModificarTurno);
            this.tabTurnos.Controls.Add(this.btnNuevoTurno);
            this.tabTurnos.Location = new System.Drawing.Point(4, 22);
            this.tabTurnos.Name = "tabTurnos";
            this.tabTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTurnos.Size = new System.Drawing.Size(443, 274);
            this.tabTurnos.TabIndex = 1;
            this.tabTurnos.Text = "Turnos";
            this.tabTurnos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Location = new System.Drawing.Point(23, 141);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(112, 38);
            this.btnEliminarTurno.TabIndex = 3;
            this.btnEliminarTurno.Text = "Eliminar Turno";
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.Location = new System.Drawing.Point(23, 87);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(111, 37);
            this.btnModificarTurno.TabIndex = 2;
            this.btnModificarTurno.Text = "ModificarTurno";
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            this.btnModificarTurno.Click += new System.EventHandler(this.btnModificarTurno_Click);
            // 
            // tabAutos
            // 
            this.tabAutos.Controls.Add(this.btnBajaAuto);
            this.tabAutos.Controls.Add(this.btnAltaAuto);
            this.tabAutos.Location = new System.Drawing.Point(4, 22);
            this.tabAutos.Name = "tabAutos";
            this.tabAutos.Size = new System.Drawing.Size(443, 274);
            this.tabAutos.TabIndex = 2;
            this.tabAutos.Text = "Autos";
            this.tabAutos.UseVisualStyleBackColor = true;
            // 
            // tabViajes
            // 
            this.tabViajes.Controls.Add(this.btnVerViajes);
            this.tabViajes.Controls.Add(this.irRegistrarViaje);
            this.tabViajes.Location = new System.Drawing.Point(4, 22);
            this.tabViajes.Name = "tabViajes";
            this.tabViajes.Size = new System.Drawing.Size(443, 274);
            this.tabViajes.TabIndex = 3;
            this.tabViajes.Text = "Viajes";
            this.tabViajes.UseVisualStyleBackColor = true;
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(19, 36);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(109, 35);
            this.btnVerViajes.TabIndex = 3;
            this.btnVerViajes.Text = "Listado de Viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            this.btnVerViajes.Click += new System.EventHandler(this.btnVerViajes_Click);
            // 
            // tabContabilidad
            // 
            this.tabContabilidad.Controls.Add(this.btnFacturacionClientes);
            this.tabContabilidad.Controls.Add(this.btnRendicionViajes);
            this.tabContabilidad.Location = new System.Drawing.Point(4, 22);
            this.tabContabilidad.Name = "tabContabilidad";
            this.tabContabilidad.Size = new System.Drawing.Size(443, 274);
            this.tabContabilidad.TabIndex = 7;
            this.tabContabilidad.Text = "Contabilidad";
            this.tabContabilidad.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionClientes
            // 
            this.btnFacturacionClientes.Location = new System.Drawing.Point(37, 100);
            this.btnFacturacionClientes.Name = "btnFacturacionClientes";
            this.btnFacturacionClientes.Size = new System.Drawing.Size(113, 41);
            this.btnFacturacionClientes.TabIndex = 1;
            this.btnFacturacionClientes.Text = "Facturacion Clientes";
            this.btnFacturacionClientes.UseVisualStyleBackColor = true;
            this.btnFacturacionClientes.Click += new System.EventHandler(this.btnFacturacionClientes_Click);
            // 
            // btnRendicionViajes
            // 
            this.btnRendicionViajes.Location = new System.Drawing.Point(35, 38);
            this.btnRendicionViajes.Name = "btnRendicionViajes";
            this.btnRendicionViajes.Size = new System.Drawing.Size(116, 38);
            this.btnRendicionViajes.TabIndex = 0;
            this.btnRendicionViajes.Text = "Rendicion Viaje";
            this.btnRendicionViajes.UseVisualStyleBackColor = true;
            this.btnRendicionViajes.Click += new System.EventHandler(this.btnRendicionViajes_Click);
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Controls.Add(this.btnConsultarEstadistica);
            this.tabEstadisticas.Controls.Add(this.radioButtonMismoAuto);
            this.tabEstadisticas.Controls.Add(this.radioButtonMasConsumo);
            this.tabEstadisticas.Controls.Add(this.radioButtonViajeMasLargo);
            this.tabEstadisticas.Controls.Add(this.radioButtonMasRecaudacion);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Size = new System.Drawing.Size(443, 274);
            this.tabEstadisticas.TabIndex = 4;
            this.tabEstadisticas.Text = "Estadisticas";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEstadistica
            // 
            this.btnConsultarEstadistica.Location = new System.Drawing.Point(42, 193);
            this.btnConsultarEstadistica.Name = "btnConsultarEstadistica";
            this.btnConsultarEstadistica.Size = new System.Drawing.Size(85, 26);
            this.btnConsultarEstadistica.TabIndex = 4;
            this.btnConsultarEstadistica.Text = "Consultar";
            this.btnConsultarEstadistica.UseVisualStyleBackColor = true;
            this.btnConsultarEstadistica.Click += new System.EventHandler(this.btnConsultarEstadistica_Click);
            // 
            // radioButtonMismoAuto
            // 
            this.radioButtonMismoAuto.AutoSize = true;
            this.radioButtonMismoAuto.Location = new System.Drawing.Point(42, 140);
            this.radioButtonMismoAuto.Name = "radioButtonMismoAuto";
            this.radioButtonMismoAuto.Size = new System.Drawing.Size(255, 17);
            this.radioButtonMismoAuto.TabIndex = 3;
            this.radioButtonMismoAuto.TabStop = true;
            this.radioButtonMismoAuto.Text = "Cliente que utilizo más veces el mismo automóvil ";
            this.radioButtonMismoAuto.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasConsumo
            // 
            this.radioButtonMasConsumo.AutoSize = true;
            this.radioButtonMasConsumo.Location = new System.Drawing.Point(42, 102);
            this.radioButtonMasConsumo.Name = "radioButtonMasConsumo";
            this.radioButtonMasConsumo.Size = new System.Drawing.Size(160, 17);
            this.radioButtonMasConsumo.TabIndex = 2;
            this.radioButtonMasConsumo.TabStop = true;
            this.radioButtonMasConsumo.Text = "Clientes con mayor consumo";
            this.radioButtonMasConsumo.UseVisualStyleBackColor = true;
            // 
            // radioButtonViajeMasLargo
            // 
            this.radioButtonViajeMasLargo.AutoSize = true;
            this.radioButtonViajeMasLargo.Location = new System.Drawing.Point(42, 63);
            this.radioButtonViajeMasLargo.Name = "radioButtonViajeMasLargo";
            this.radioButtonViajeMasLargo.Size = new System.Drawing.Size(217, 17);
            this.radioButtonViajeMasLargo.TabIndex = 1;
            this.radioButtonViajeMasLargo.TabStop = true;
            this.radioButtonViajeMasLargo.Text = "Choferes con el viaje mas largo realizado";
            this.radioButtonViajeMasLargo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasRecaudacion
            // 
            this.radioButtonMasRecaudacion.AutoSize = true;
            this.radioButtonMasRecaudacion.Location = new System.Drawing.Point(42, 25);
            this.radioButtonMasRecaudacion.Name = "radioButtonMasRecaudacion";
            this.radioButtonMasRecaudacion.Size = new System.Drawing.Size(182, 17);
            this.radioButtonMasRecaudacion.TabIndex = 0;
            this.radioButtonMasRecaudacion.TabStop = true;
            this.radioButtonMasRecaudacion.Text = "Choferes con Mayor recaudación";
            this.radioButtonMasRecaudacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblMenu);
            this.Name = "Principal";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tblMenu.ResumeLayout(false);
            this.tabSeguridad.ResumeLayout(false);
            this.tabChoferes.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabTurnos.ResumeLayout(false);
            this.tabAutos.ResumeLayout(false);
            this.tabViajes.ResumeLayout(false);
            this.tabContabilidad.ResumeLayout(false);
            this.tabEstadisticas.ResumeLayout(false);
            this.tabEstadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoTurno;
        private System.Windows.Forms.Button irRegistrarViaje;
        private System.Windows.Forms.Button btnBajaAuto;
        private System.Windows.Forms.Button btnAltaAuto;
        private System.Windows.Forms.Button btnBajaRol;
        private System.Windows.Forms.Button btnModificarRol;
        private System.Windows.Forms.Button btnAltaRol;
        private System.Windows.Forms.TabControl tblMenu;
        private System.Windows.Forms.TabPage tabSeguridad;
        private System.Windows.Forms.TabPage tabTurnos;
        private System.Windows.Forms.TabPage tabAutos;
        private System.Windows.Forms.TabPage tabViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.RadioButton radioButtonMismoAuto;
        private System.Windows.Forms.RadioButton radioButtonMasConsumo;
        private System.Windows.Forms.RadioButton radioButtonViajeMasLargo;
        private System.Windows.Forms.Button btnConsultarEstadistica;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabChoferes;
        private System.Windows.Forms.TabPage tabContabilidad;
        private System.Windows.Forms.Button btnFacturacionClientes;
        private System.Windows.Forms.Button btnRendicionViajes;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button ModificarCliente;
        private System.Windows.Forms.Button NuevoCliente;
        private System.Windows.Forms.Button btnModificarChofer;
        private System.Windows.Forms.Button btnNuevoChofer;
        private System.Windows.Forms.RadioButton radioButtonMasRecaudacion;
    }
}