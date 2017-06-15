namespace UberFrba.Listado_Estadistico
{
    partial class MismoAuto
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
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(45, 344);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(112, 31);
            this.btnPrincipal.TabIndex = 9;
            this.btnPrincipal.Text = "Menu Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(45, 95);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(544, 230);
            this.dataGrid.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTrimestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Consultar);
            this.groupBox1.Controls.Add(this.cmbAnio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar";
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(262, 22);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(121, 21);
            this.cmbTrimestre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trimestre";
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(416, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(96, 24);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(52, 22);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // MismoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 388);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "MismoAuto";
            this.Text = "Uber Estadisticas";
            this.Load += new System.EventHandler(this.MismoAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label label1;
    }
}