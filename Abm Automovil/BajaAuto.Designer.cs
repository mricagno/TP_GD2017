namespace UberFrba.Abm_Automovil
{
    partial class BajaAuto
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
            this.cmbPatentes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnBajaAuto = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPatentes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(29, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Auto";
            // 
            // cmbPatentes
            // 
            this.cmbPatentes.FormattingEnabled = true;
            this.cmbPatentes.Location = new System.Drawing.Point(93, 40);
            this.cmbPatentes.Name = "cmbPatentes";
            this.cmbPatentes.Size = new System.Drawing.Size(121, 21);
            this.cmbPatentes.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patente";
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(29, 159);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(101, 34);
            this.btnMenuPrincipal.TabIndex = 19;
            this.btnMenuPrincipal.Text = " Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnBajaAuto
            // 
            this.btnBajaAuto.Location = new System.Drawing.Point(184, 158);
            this.btnBajaAuto.Name = "btnBajaAuto";
            this.btnBajaAuto.Size = new System.Drawing.Size(102, 35);
            this.btnBajaAuto.TabIndex = 18;
            this.btnBajaAuto.Text = "Eliminar Auto";
            this.btnBajaAuto.UseVisualStyleBackColor = true;
            this.btnBajaAuto.Click += new System.EventHandler(this.btnBajaAuto_Click);
            // 
            // BajaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 293);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnBajaAuto);
            this.Controls.Add(this.groupBox2);
            this.Name = "BajaAuto";
            this.Text = "Baja Auto";
            this.Load += new System.EventHandler(this.BajaAuto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPatentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnBajaAuto;
    }
}