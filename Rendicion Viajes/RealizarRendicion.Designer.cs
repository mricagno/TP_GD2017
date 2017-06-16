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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(22, 321);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(101, 34);
            this.btnMenuPrincipal.TabIndex = 22;
            this.btnMenuPrincipal.Text = " Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnRendirViaje
            // 
            this.btnRendirViaje.Location = new System.Drawing.Point(328, 320);
            this.btnRendirViaje.Name = "btnRendirViaje";
            this.btnRendirViaje.Size = new System.Drawing.Size(102, 35);
            this.btnRendirViaje.TabIndex = 21;
            this.btnRendirViaje.Text = "Rendir Viaje";
            this.btnRendirViaje.UseVisualStyleBackColor = true;
            this.btnRendirViaje.Click += new System.EventHandler(this.btnRendirViaje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstChoferes);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 290);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar chofer";
            // 
            // lstChoferes
            // 
            this.lstChoferes.FormattingEnabled = true;
            this.lstChoferes.Location = new System.Drawing.Point(15, 31);
            this.lstChoferes.Name = "lstChoferes";
            this.lstChoferes.Size = new System.Drawing.Size(120, 238);
            this.lstChoferes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateRendicion);
            this.groupBox2.Location = new System.Drawing.Point(206, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 152);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Fecha";
            // 
            // dateRendicion
            // 
            this.dateRendicion.CustomFormat = "yyyy/mm/dd hh:mm";
            this.dateRendicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRendicion.Location = new System.Drawing.Point(24, 31);
            this.dateRendicion.Name = "dateRendicion";
            this.dateRendicion.Size = new System.Drawing.Size(200, 20);
            this.dateRendicion.TabIndex = 0;
            // 
            // RealizarRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnRendirViaje);
            this.Name = "RealizarRendicion";
            this.Text = "Rendir";
            this.Load += new System.EventHandler(this.RealizarRendicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnRendirViaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstChoferes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateRendicion;
    }
}