namespace UberFrba.Turno
{
    partial class ModificarTurno
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTurnos);
            this.groupBox1.Location = new System.Drawing.Point(34, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Turno";
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(15, 32);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(157, 21);
            this.cmbTurnos.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(147, 148);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.Location = new System.Drawing.Point(34, 148);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(79, 35);
            this.btnVolverPrincipal.TabIndex = 2;
            this.btnVolverPrincipal.Text = "Volver";
            this.btnVolverPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // ModificarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVolverPrincipal);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarTurno";
            this.Text = "ModificarTurno";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolverPrincipal;
    }
}