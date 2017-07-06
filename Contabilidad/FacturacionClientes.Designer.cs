namespace UberFrba.Contabilidad
{
    partial class FacturacionClientes
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateFactura = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.GridFacturacion = new System.Windows.Forms.DataGridView();
            this.Fact_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateFactura);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 60);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Fecha";
            // 
            // dateFactura
            // 
            this.dateFactura.CustomFormat = "yyyy/MM";
            this.dateFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFactura.Location = new System.Drawing.Point(22, 24);
            this.dateFactura.Name = "dateFactura";
            this.dateFactura.Size = new System.Drawing.Size(218, 20);
            this.dateFactura.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 337);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Clientes";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(22, 31);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(120, 290);
            this.lstClientes.TabIndex = 0;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(36, 415);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(101, 34);
            this.btnMenuPrincipal.TabIndex = 26;
            this.btnMenuPrincipal.Text = " Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(647, 414);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(102, 35);
            this.btnFacturar.TabIndex = 25;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // GridFacturacion
            // 
            this.GridFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFacturacion.Location = new System.Drawing.Point(206, 69);
            this.GridFacturacion.Name = "GridFacturacion";
            this.GridFacturacion.ReadOnly = true;
            this.GridFacturacion.Size = new System.Drawing.Size(543, 339);
            this.GridFacturacion.TabIndex = 29;
            this.GridFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fact_total
            // 
            this.Fact_total.Enabled = false;
            this.Fact_total.Location = new System.Drawing.Point(561, 24);
            this.Fact_total.Name = "Fact_total";
            this.Fact_total.Size = new System.Drawing.Size(187, 20);
            this.Fact_total.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total facturado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FacturacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fact_total);
            this.Controls.Add(this.GridFacturacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnFacturar);
            this.Name = "FacturacionClientes";
            this.Text = "Facturacion Clientes";
            this.Load += new System.EventHandler(this.FacturacionClientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridView GridFacturacion;
        private System.Windows.Forms.TextBox Fact_total;
        private System.Windows.Forms.Label label1;
    }
}