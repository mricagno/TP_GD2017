namespace UberFrba.Turno
{
    partial class BajaTurno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTurnos);
            this.groupBox1.Location = new System.Drawing.Point(53, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Turno";
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(18, 38);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(130, 21);
            this.cmbTurnos.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(139, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 24);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.Location = new System.Drawing.Point(39, 166);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(80, 24);
            this.btnVolverPrincipal.TabIndex = 2;
            this.btnVolverPrincipal.Text = "Volver";
            this.btnVolverPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // BajaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVolverPrincipal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaTurno";
            this.Text = "Baja Turno";
            this.Load += new System.EventHandler(this.BajaTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolverPrincipal;
    }
}