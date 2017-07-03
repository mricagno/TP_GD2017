namespace UberFrba.Rendicion_Viajes
{
    partial class RealizarRendicion
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
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnRendirViaje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstChoferes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateRendicion = new System.Windows.Forms.DateTimePicker();
            this.GridViajesRendidos = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalviajes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViajesRendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(204, 410);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(101, 34);
            this.btnMenuPrincipal.TabIndex = 22;
            this.btnMenuPrincipal.Text = " Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnRendirViaje
            // 
            this.btnRendirViaje.Location = new System.Drawing.Point(646, 412);
            this.btnRendirViaje.Name = "btnRendirViaje";
            this.btnRendirViaje.Size = new System.Drawing.Size(101, 32);
            this.btnRendirViaje.TabIndex = 21;
            this.btnRendirViaje.Text = "Rendir";
            this.btnRendirViaje.UseVisualStyleBackColor = true;
            this.btnRendirViaje.Click += new System.EventHandler(this.btnRendirViaje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstChoferes);
            this.groupBox1.Location = new System.Drawing.Point(21, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar chofer";
            // 
            // lstChoferes
            // 
            this.lstChoferes.FormattingEnabled = true;
            this.lstChoferes.Location = new System.Drawing.Point(15, 31);
            this.lstChoferes.Name = "lstChoferes";
            this.lstChoferes.Size = new System.Drawing.Size(120, 264);
            this.lstChoferes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateRendicion);
            this.groupBox2.Location = new System.Drawing.Point(21, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 69);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Fecha";
            // 
            // dateRendicion
            // 
            this.dateRendicion.CustomFormat = "yyyy/MM/dd";
            this.dateRendicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRendicion.Location = new System.Drawing.Point(15, 32);
            this.dateRendicion.Name = "dateRendicion";
            this.dateRendicion.Size = new System.Drawing.Size(111, 20);
            this.dateRendicion.TabIndex = 0;
            this.dateRendicion.ValueChanged += new System.EventHandler(this.dateRendicion_ValueChanged);
            // 
            // GridViajesRendidos
            // 
            this.GridViajesRendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViajesRendidos.Location = new System.Drawing.Point(204, 35);
            this.GridViajesRendidos.Name = "GridViajesRendidos";
            this.GridViajesRendidos.ReadOnly = true;
            this.GridViajesRendidos.Size = new System.Drawing.Size(543, 339);
            this.GridViajesRendidos.TabIndex = 25;
            this.GridViajesRendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViajesRendidos_CellContentClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(549, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(198, 20);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total Rendido";
            // 
            // txttotalviajes
            // 
            this.txttotalviajes.Location = new System.Drawing.Point(299, 9);
            this.txttotalviajes.Name = "txttotalviajes";
            this.txttotalviajes.Size = new System.Drawing.Size(149, 20);
            this.txttotalviajes.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total Viajes";
            // 
            // RealizarRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotalviajes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.GridViajesRendidos);
            this.Controls.Add(this.btnRendirViaje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Name = "RealizarRendicion";
            this.Text = "Rendir";
            this.Load += new System.EventHandler(this.RealizarRendicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViajesRendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnRendirViaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstChoferes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateRendicion;
        private System.Windows.Forms.DataGridView GridViajesRendidos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalviajes;
        private System.Windows.Forms.Label label2;
    }
}